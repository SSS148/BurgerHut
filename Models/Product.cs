using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BurgerHut.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Display(Name = "Item Name ")]
        public string Name { get; set; }

        [Display(Name = "Ingridient")]
        public string Ingridient { get; set; }


        [Display(Name = "Price ")]
        public int Price { get; set; }

        [Display(Name = "Upload Image ")]
        public string pic { get; set; }

    }
}
