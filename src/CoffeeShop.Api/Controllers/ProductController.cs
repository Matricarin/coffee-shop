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
                Result = await dbContext.Products.AsNoTracking().ToListAsync(),
                HttpStatusCode = System.Net.HttpStatusCode.OK
            });
        }


        [HttpGet]
        public async Task<IActionResult> GetProduct(Guid guid)
        {
            if (guid == Guid.Empty)
            {
                return BadRequest(
                    new CoffeeShopResponse()
                    {
                        HttpStatusCode = System.Net.HttpStatusCode.BadRequest,
                        IsSuccess = false,
                        Result = null
                    }
                );
            }

            var product = await dbContext.Products.AsNoTracking().FirstOrDefaultAsync(p => p.Id == guid);

            if (product is null)
            {
                return NotFound(new CoffeeShopResponse()
                {
                    HttpStatusCode = System.Net.HttpStatusCode.NotFound,
                    IsSuccess = false,
                    Result = null,
                    ErrorMessages = ["Product wasn't found"]
                });
            }

            return Ok(new CoffeeShopResponse()
            {
                HttpStatusCode = System.Net.HttpStatusCode.OK,
                Result = product,
                IsSuccess = true
            });
        }

        //  TODO remove product

        //  TODO update product

        //  TODO create product
    }
}