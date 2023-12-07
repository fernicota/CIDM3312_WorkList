using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CIDM3312_WorkList.Models;

namespace CIDM3312_WorkList.Pages.UserWorkPages.Works
{
    public class DeleteModel : PageModel
    {
        private readonly CIDM3312_WorkList.Models.UserWorkDbContext _context;

        public DeleteModel(CIDM3312_WorkList.Models.UserWorkDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Work Work { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Works == null)
            {
                return NotFound();
            }

            var work = await _context.Works.FirstOrDefaultAsync(m => m.WorkId == id);

            if (work == null)
            {
                return NotFound();
            }
            else 
            {
                Work = work;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Works == null)
            {
                return NotFound();
            }
            var work = await _context.Works.FindAsync(id);

            if (work != null)
            {
                Work = work;
                _context.Works.Remove(Work);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./WorkIndex");
        }
    }
}
