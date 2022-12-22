using ETicaretAPI.Application.Abstract;
using ETicaretAPI.Domain.Entities.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdctsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProdctsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public IActionResult GetProducts()
        {
           var product=_productService.GetProducts();
            return Ok(product);
        }
    }
}
