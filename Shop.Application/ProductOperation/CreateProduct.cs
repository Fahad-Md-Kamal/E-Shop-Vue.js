using Shop.Database;
using Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.ProductOperation
{
    public class CreateProduct
    {
        private ApplicationDBConetext _context;

        public CreateProduct(ApplicationDBConetext conetext)
        {
            _context = conetext;
        }

        public async Task Do(string _name, string _desc, decimal _price)
        {
            _context.Product.Add(new Product
            {
                Name = _name,
                Description = _desc,
                Price = _price
            });

            await _context.SaveChangesAsync();
        }



    }
}
