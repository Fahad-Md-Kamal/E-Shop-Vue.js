using Shop.Database;
using Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.ProductAdmin
{
    public class UpdateProduct
    {
        private ApplicationDBContext _context;

        public UpdateProduct(ApplicationDBContext conetext)
        {
            _context = conetext;
        }

        public async Task Do(ProductViewModel vm)
        {
            await _context.SaveChangesAsync();
        }

        public class ProductViewModel
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }
        }
    }



}
