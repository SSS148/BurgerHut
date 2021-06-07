using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BurgerHut.Data;
using BurgerHut.Models;

namespace BurgerHut.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly BurgerHut.Data.BurgerHutContext _context;

        public IndexModel(BurgerHut.Data.BurgerHutContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; }

        public async Task OnGetAsync()
        {
            Order = await _context.Order.ToListAsync();
        }
    }
}
