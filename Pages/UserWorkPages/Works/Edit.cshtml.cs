using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CIDM3312_WorkList.Models;

namespace CIDM3312_WorkList.Pages.UserWorkPages.Works
{
    public class EditModel : PageModel
    {
        private readonly CIDM3312_WorkList.Models.UserWorkDbContext _context;

        public EditModel(CIDM3312_WorkList.Models.UserWorkDbContext context)
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

            var work =  await _context.Works.FirstOrDefaultAsync(m => m.WorkId == id);
            if (work == null)
            {
                return NotFound();
            }
            Work = work;
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Name");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Work).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WorkExists(Work.WorkId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./WorkIndex");
        }

        private bool WorkExists(int id)
        {
          return (_context.Works?.Any(e => e.WorkId == id)).GetValueOrDefault();
        }
    }
}
