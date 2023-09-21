using ECommerce.Business.Abstract;
using ECommerce.Entities.Concrete;
using ECommerce.Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavouriteListController : ControllerBase
    {
        IFavouriteListService _favouriteListService;
        public FavouriteListController(IFavouriteListService favouriteList)
        {   
            _favouriteListService=favouriteList;
        }

        [HttpPost("AddToFavouriteList")]

        public IActionResult AddToFavouriteList(FavouriteList favouriteList)
        {
            try
            {
                _favouriteListService.AddToFavouriteList(favouriteList);
                return Ok("Successful");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error occured! : " + ex.Message);
            }

        }





        //[HttpPost("add")]
        //public IActionResult AddToFavourites()
        //{
        //    var result = _favouriteListService.AddToFavouriteList(request.ProductID,request.CustomerID);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}
    }
}
