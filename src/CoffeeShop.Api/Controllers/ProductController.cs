using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Api.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            throw new NotImplementedException();
        }
        

        //  TODO get product

        //  TODO remove product

        //  TODO update product

        //  TODO create product
    }
}