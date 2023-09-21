using ECommerce.Business.Abstract;
using ECommerce.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    public class CartController : Controller
    {
        ICartService _cartService;
        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }
        [HttpPost("AddToCart")]

        public IActionResult AddToCart(Cart cart)
        {
            try
            {
                _cartService.AddToCart(cart);
                return Ok("Successful");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error occured! : " + ex.Message);
            }

        }
        [HttpDelete("DeleteFromCart")]

        public IActionResult DeleteFromCart(Cart cart)
        {
            try
            {
                _cartService.DeleteFromCart(cart);
                return Ok("Successful");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error occured! : " + ex.Message);
            }

        }
        [HttpPost("UpdateFromCart")]

        public IActionResult UpdateFromCart(Cart cart)
        {
            try
            {
                _cartService.UpdateCard(cart);
                return Ok("Successful");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error occured! : " + ex.Message);
            }

        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int productId)
        {
            var result = _cartService.GetById(productId);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _cartService.GetAll();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

    }
}
