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

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
           await new CreateProduct(_context).Do(Product);

            return RedirectToPage("Index");
        }

    }
}
