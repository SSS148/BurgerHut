using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BurgerHut.Data;
using BurgerHut.Models;

namespace BurgerHut.Pages.staff
{
    public class EditModel : PageModel
    {
        private readonly BurgerHut.Data.BurgerHutContext _context;

        public EditModel(BurgerHut.Data.BurgerHutContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Employeecs).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeecsExists(Employeecs.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool EmployeecsExists(int id)
        {
            return _context.Employeecs.Any(e => e.Id == id);
        }
    }
}
