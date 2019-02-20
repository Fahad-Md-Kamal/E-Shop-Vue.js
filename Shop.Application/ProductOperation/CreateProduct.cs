using Shop.Database;
using Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Application.ProductOperation
{
    public class CreateProduct
    {
        private ApplicationDBConetext _context;

        public CreateProduct(ApplicationDBConetext conetext)
        {
            _context = conetext;
        }

        public void Do(int _id, string _name, string _desc, decimal _price)
        {
            _context.Product.Add(new Product
            {
                Id = _id,
                Name = _name,
                Description = _desc,
                Price = _price
            });
        }



    }
}
