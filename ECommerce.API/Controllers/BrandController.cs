using ECommerce.Business.Abstract;
using ECommerce.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BrandController : ControllerBase
    {
        IBrandService _brandService;
        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }
        [HttpPost("AddBrand")]

        public IActionResult Add(Brand brand)
        {
            try
            {
                _brandService.Add(brand);
                return Ok("Successful");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error occured! : " + ex.Message);
            }

        }
        [HttpDelete("DeleteBrand")]

        public IActionResult Delete(Brand brand)
        {
            try
            {
                _brandService.Delete(brand);
                return Ok("Successful");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error occured! : " + ex.Message);
            }

        }
    }
}
