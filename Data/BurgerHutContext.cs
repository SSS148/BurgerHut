using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BurgerHut.Models;

namespace BurgerHut.Data
{
    public class BurgerHutContext : DbContext
    {
        public BurgerHutContext (DbContextOptions<BurgerHutContext> options)
            : base(options)
        {
        }

        public DbSet<BurgerHut.Models.Product> Product { get; set; }

        public DbSet<BurgerHut.Models.Employeecs> Employeecs { get; set; }

        public DbSet<BurgerHut.Models.Order> Order { get; set; }
    }
}
