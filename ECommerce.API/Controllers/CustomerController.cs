using ECommerce.Business.Abstract;
using ECommerce.Entities.Concrete;
using ECommerce.Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpPost("add")]
        public IActionResult Add(Customer customer)
        {
            var result = _customerService.Add(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("updateaddress")]
        public IActionResult UpdateAddress(Customer customer,string newAddress)
        {
            var result = _customerService.UpdateAddress(customer, newAddress);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("RemoveCustomer")]

        public IActionResult Delete(Customer customer)
        {
            try
            {
                _customerService.RemoveCustomer(customer);
                return Ok("Successful!");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error occured! : " + ex.Message);


            }
        }

        [HttpPut("Login")]

        public IActionResult Login(CustomerForLoginDto customerForLoginDto)
        {
            try
            {
                var result = _customerService.Login(customerForLoginDto);
                return Ok(result);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error occured! : " + ex.Message);
            }


        }
    }


}
