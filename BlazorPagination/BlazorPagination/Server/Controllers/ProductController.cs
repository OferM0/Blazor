using BlazorPagination.Server.Data;
using BlazorPagination.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorPagination.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DataContext _context;

        public ProductController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{page}")]
        public async Task<ActionResult<List<Product>>> GetProducts(int page)
        {
            if (_context.Products == null)
                return NotFound();

            var pageResults = 3f;
            var pageCount = Math.Ceiling(_context.Products.Count() / pageResults);

            var products = await _context.Products
                .Skip((page - 1) * (int)pageResults)
                .Take((int)pageResults)
                .ToListAsync();

            var response = new ProductResponse
            {
                Products = products,
                CurrentPage = page,
                Pages = (int)pageCount
            };

            return Ok(response);
        }
    }
}
