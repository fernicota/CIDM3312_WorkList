using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CIDM3312_WorkList.Models;

namespace CIDM3312_WorkList.Pages.UserWorkPages.Works
{
    public class CreateModel : PageModel
    {
        private readonly CIDM3312_WorkList.Models.UserWorkDbContext _context;

        public CreateModel(CIDM3312_WorkList.Models.UserWorkDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Name");
            return Page();
        }

        [BindProperty]
        public Work Work { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Works == null || Work == null)
            {
                return Page();
            }

            _context.Works.Add(Work);
            await _context.SaveChangesAsync();

            return RedirectToPage("./WorkIndex");
        }
    }
}
