using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Application.Products;
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


        public IEnumerable<GetProducts.ProductViewModel> Products { get; set; }



        public void OnGet()
        {
           Products = new GetProducts(_context).Do();
        }

    }
}
