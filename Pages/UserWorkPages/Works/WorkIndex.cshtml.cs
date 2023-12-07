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
    public class WorkIndexModel : PageModel
    {
        private readonly UserWorkDbContext _context;
        public int PageSize = 10; //paging
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }

        [BindProperty(SupportsGet = true)] // Bind this property with query string
        public string SortOrder { get; set; } = string.Empty;

        public IList<Work> Work {get; set;} = default!;

        public WorkIndexModel(UserWorkDbContext context)
        {
            _context = context;
        }


        public async Task OnGetAsync(int currentPage = 1)
        {
            IQueryable<Work> workQuery = _context.Works.Include(o => o.User);

            //searching function
            switch (SortOrder)
            {
                case "name_desc":
                    workQuery = workQuery.OrderByDescending(p => p.Duration);
                    break;
                case "name_asc":
                default:
                    workQuery = workQuery.OrderBy(p => p.Name);
                    break;
            }

            //paging
            var totalRecords = await workQuery.CountAsync();
            TotalPages = (int)Math.Ceiling(totalRecords / (double)PageSize);

            CurrentPage = currentPage; //paging
            Work = await workQuery.Skip((CurrentPage - 1) * PageSize) //paging
                                  .Take(PageSize)
                                  .ToListAsync();
        }
    }
}