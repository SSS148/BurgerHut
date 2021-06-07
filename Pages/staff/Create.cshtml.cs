using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BurgerHut.Data;
using BurgerHut.Models;

namespace BurgerHut.Pages.staff
{
    public class CreateModel : PageModel
    {
        private readonly BurgerHut.Data.BurgerHutContext _context;

        public CreateModel(BurgerHut.Data.BurgerHutContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Employeecs Employeecs { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Employeecs.Add(Employeecs);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
