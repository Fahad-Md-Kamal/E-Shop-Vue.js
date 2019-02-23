using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Application.CreateProduct;
using Shop.Application.GetProduct;
using Shop.Database;

namespace Shop.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDBContext _context;

        public IndexModel(ApplicationDBContext conetext)
        {
            _context = conetext;
        }

        [BindProperty]
        public Application.CreateProduct.ProductViewModel Product { get; set; }


        public IEnumerable<Application.GetProduct.ProductViewModel> Products { get; set; }



        public void OnGet()
        {
           Products = new GetProducts(_context).Do();
        }



        public async Task<IActionResult> OnPost()
        {
           await new CreateProduct(_context).Do(Product);

            return RedirectToPage("Index");
        }

    }
}
