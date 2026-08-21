using CoffeeShop.Api.Data;
using CoffeeShop.Api.Models;

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
            return Ok(new CoffeeShopResponse
            {
                Result = await dbContext.Products.ToListAsync(),
                HttpStatusCode = System.Net.HttpStatusCode.OK
            });
        }
        

        //  TODO get product

        //  TODO remove product

        //  TODO update product

        //  TODO create product
    }
}