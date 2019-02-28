using Microsoft.AspNetCore.Mvc;
using Shop.Application.ProductAdmin;
using Shop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.UI.Controllers
{
    [Route("[controller]")]
    public class AdminController : Controller
    {
        private ApplicationDBContext _context;

        public AdminController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet("products")]
        public IActionResult GetProducts()
        {
            return Ok(new GetProducts(_context).Do());
        }



        [HttpGet("products/{id}")]
        public IActionResult GetProduct(int id)
        {
            return Ok(new GetProduct(_context).Do(id));
        }



        [HttpPost("products")]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProduct.Request request)
        {
            return Ok(await new CreateProduct(_context).Do(request));
        }



        [HttpDelete("products/{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            return Ok(await new DeleteProduct(_context).Do(id));
        }



        [HttpPut("products")]
        public async Task<IActionResult> UpdateProduct([FromBody] UpdateProduct.Request request)
        {
            return Ok(await new UpdateProduct(_context).Do(request));
        }
    }
}
