using Shop.Database;
using Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.ProductAdmin
{
    public class DeleteProduct
    {
        private ApplicationDBContext _context;

        public DeleteProduct(ApplicationDBContext conetext)
        {
            _context = conetext;
        }
         
        public async Task<bool> Do(int id)
        {
            var Product = _context.Products.FirstOrDefault(x => x.Id == id);
            _context.Products.Remove(Product);
            await _context.SaveChangesAsync();

            return true;
        }

    }



}
