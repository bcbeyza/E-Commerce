using ECommerce.Business.Abstract;
using ECommerce.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getbycategoryid")]
        public IActionResult GetByCategoryId(int categoryId)
        {
            var result = _productService.GetAllByCategoryId(categoryId);
            if(result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _productService.GetAll();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int productId)
        {
            var result = _productService.GetById(productId);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpPost("updateproduct")]
        public IActionResult UpdateProduct(Product product)
        {
            var result = _productService.UpdateProduct(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("deleteproduct")]
        public IActionResult DeleteProduct(Product product)
        {
            var result = _productService.DeleteProduct(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbybrandyid")]
        public IActionResult GetByBrandId(int brandId)
        {
            var result = _productService.GetAllByCategoryId(brandId);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpGet("getbycolorid")]
        public IActionResult GetByColorId(int colorId)
        {
            var result = _productService.GetAllByCategoryId(colorId);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

    }
}
