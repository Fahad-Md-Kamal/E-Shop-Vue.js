using Shop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Application.GetProduct
{
    public class GetProducts
    {
        private ApplicationDBContext _context;

        public GetProducts(ApplicationDBContext context)
        {
            _context = context;
        }


        public IEnumerable<ProductViewModel> Do() => 
            _context.Products.ToList().Select(x => new ProductViewModel
        {
            Name = x.Name,
            Description = x.Description,
            Price = $"$ {x.Price.ToString("N2")}", // 1100.50 => 1,100 => $ 1100.50
        });
    }

    public class ProductViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
    }
}
