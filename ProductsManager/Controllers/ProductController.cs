using Microsoft.AspNetCore.Mvc;
using ProductsManager.Services;

namespace ProductsManager.Controllers
{
    [Route("api/product")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet("SKU")]
        public ActionResult GetBySku([FromRoute]string SKU) 
        {
            var result = _productService.GetBySKU(SKU);

            if (result == null) return NotFound();

            return Ok(result);
        }
    }
}
