using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BurgerHut.Data;
using BurgerHut.Models;
using System.IO;
using Microsoft.Extensions.FileProviders;

namespace BurgerHut.Pages.Items
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
        public Product Product { get; set; }


        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
           /* IFormFile fle;
            string fileName = Path.GetFileName(fle.FileName);

            //Assigning Unique Filename (Guid)
            var myUniqueFileName = Convert.ToString(Guid.NewGuid());

            //Getting file Extension
            var fileExtension = Path.GetExtension(fileName);

            // concatenating  FileName + FileExtension
            var newFileName = String.Concat(myUniqueFileName, fileExtension);

            // Combines two strings into a path.
            var filepath =new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "img")).Root + $@"\{newFileName}";

            using (FileStream fs = System.IO.File.Create(filepath))
            {
                Product.pic.CopyTo(fs);
                fs.Flush();
            }
           */
            _context.Product.Add(Product);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
