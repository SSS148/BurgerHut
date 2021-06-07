using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BurgerHut.Data;
using BurgerHut.Models;

namespace BurgerHut.Pages.staff
{
    public class DeleteModel : PageModel
    {
        private readonly BurgerHut.Data.BurgerHutContext _context;

        public DeleteModel(BurgerHut.Data.BurgerHutContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Employeecs Employeecs { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employeecs = await _context.Employeecs.FirstOrDefaultAsync(m => m.Id == id);

            if (Employeecs == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employeecs = await _context.Employeecs.FindAsync(id);

            if (Employeecs != null)
            {
                _context.Employeecs.Remove(Employeecs);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
