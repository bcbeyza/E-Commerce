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

        [HttpPost("AddFavouriteList")]

        public IActionResult AddFavouriteList(FavouriteList favouriteList)
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
        [HttpDelete("RemoveFromFavouriteList")]

        public IActionResult RemoveFromFavouriteList(FavouriteList favouriteList)
        {
            try
            {
                _favouriteListService.RemoveFromFavouriteList(favouriteList);
                return Ok("Successful");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error occured! : " + ex.Message);
            }

        }





    }
}
