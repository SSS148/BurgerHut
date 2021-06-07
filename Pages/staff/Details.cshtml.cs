﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly BurgerHut.Data.BurgerHutContext _context;

        public DetailsModel(BurgerHut.Data.BurgerHutContext context)
        {
            _context = context;
        }

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
    }
}
