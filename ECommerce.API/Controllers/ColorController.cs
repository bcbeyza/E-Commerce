using ECommerce.Business.Abstract;
using ECommerce.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorController : ControllerBase
    {
        IColorService _colorService;
        public ColorController(IColorService colorService)
        {
            _colorService = colorService;   
        }
        [HttpPost("AddColor")]

        public IActionResult Add(Color color)
        {
            try
            {
                _colorService.Add(color);
                return Ok("Successful");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error occured! : " + ex.Message);
            }

        }
        [HttpPost("DeleteColor")]

        public IActionResult Delete(Color color)
        {
            try
            {
                _colorService.Delete(color);
                return Ok("Successful");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error occured! : " + ex.Message);
            }

        }
    }
}
