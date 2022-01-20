using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

		[HttpGet]
		public async Task<ActionResult<List<Product>>> GetProducts()
        {
			return Ok(Products);
        }
	}
}
