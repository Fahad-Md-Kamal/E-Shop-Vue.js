using Shop.Database;
using Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.CreateProduct
{
    public class CreateProduct
    {
        private ApplicationDBContext _context;

        public CreateProduct(ApplicationDBContext conetext)
        {
            _context = conetext;
        }

        public async Task Do(ProductViewModel vm)
        {
            _context.Products.Add(new Product
            {
                Name = vm.Name,
                Description = vm.Description,
                Price = vm.Price
            });

            await _context.SaveChangesAsync();
        }
    }

    public class ProductViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }

}
