using ECommerce.Business.Abstract;
using ECommerce.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
        
        public class CreditCardController : ControllerBase
        {
            ICreditCardService _creditCardService;

            public CreditCardController(ICreditCardService creditCardService)
            {
                _creditCardService = creditCardService;
            }

            [HttpPost("addCardInfo")]

            public IActionResult AddCard(CreditCard credit)
            {
                try
                {
                    _creditCardService.AddCard(credit);
                    return Ok("Successful");
                }
                catch (Exception ex)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, "Error occured! : " + ex.Message);
                }

            }

            [HttpDelete("deleteCardInfo")]
            public IActionResult DeleteCard(CreditCard creditCard)
            {
                try
                {
                    _creditCardService.DeleteCard(creditCard);
                    return Ok("Successful");
                }
                catch (Exception ex)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, "Error occured! : " + ex.Message);
                }
            }

            [HttpPut("updateCardInfo")]
            public IActionResult UpdateCard(CreditCard creditCard)
            {
                try
                {
                    _creditCardService.UpdateCard(creditCard);
                    return Ok("Successful");
                }
                catch (Exception ex)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, "Error occured! : " + ex.Message);
                }
            }

            [HttpGet("getByCardId")]
            public IActionResult GetByCardId(int cardId)
            {
                try
                {
                    _creditCardService.GetByCardId(cardId);
                    return Ok("Successful");
                }
                catch (Exception ex)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, "Error occured! : " + ex.Message);
                }
            }
        }

    
}
