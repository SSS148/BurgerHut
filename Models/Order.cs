using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BurgerHut.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Display(Name = "Name ")]
        public string Name { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Mobile No")]
        public int Mobile { get; set; }

        [Display(Name = "Product Name ")]
        public string ProductName { get; set; }

    }
}
