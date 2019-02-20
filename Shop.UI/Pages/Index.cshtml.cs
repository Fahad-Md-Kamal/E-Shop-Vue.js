using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Application.ProductOperation;
using Shop.Database;

namespace Shop.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDBConetext _context;

        public IndexModel(ApplicationDBConetext conetext)
        {
            _context = conetext;
        }

        [BindProperty]
        public ProductViewModel Product { get; set; }

        public class ProductViewModel
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
           await new CreateProduct(_context).Do(Product.Name, Product.Description, Product.Price);

            return RedirectToPage("Index");
        }

    }
}
