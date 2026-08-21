using CoffeeShop.Api.Data;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.Api.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly CoffeeShopDbContext dbContext;

        public ProductController(CoffeeShopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            return Ok(await dbContext.Products.ToListAsync());
        }
        

        //  TODO get product

        //  TODO remove product

        //  TODO update product

        //  TODO create product
    }
}