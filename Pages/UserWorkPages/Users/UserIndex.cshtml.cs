using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CIDM3312_WorkList.Models;

namespace CIDM3312_WorkList.Pages.UserWorkPages
{
    public class UserIndexModel : PageModel
    {
        private readonly UserWorkDbContext _context;
        public int PageSize = 10; //paging
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }

        [BindProperty(SupportsGet = true)] // Bind this property with query string
        public string SearchString { get; set; } = string.Empty;

        public IList<User> User {get; set;} = default!;

        public UserIndexModel(UserWorkDbContext context)
        {
            _context = context;
        }


        public async Task OnGetAsync(int currentPage = 1)
        {
            IQueryable<User> userQuery = _context.Users;

            //searching function
            if (!string.IsNullOrEmpty(SearchString))
            {
                userQuery = userQuery.Where(o => o.Name.Contains(SearchString)
                                            || o.SkillLevel.Contains(SearchString));
            }

            //paging
            var totalRecords = await userQuery.CountAsync();
            TotalPages = (int)Math.Ceiling(totalRecords / (double)PageSize);

            CurrentPage = currentPage; //paging
            User = await userQuery.Include(o => o.Works)
                                         .Skip((CurrentPage - 1) * PageSize) //paging
                                         .Take(PageSize)
                                         .ToListAsync();
        }
    }
}