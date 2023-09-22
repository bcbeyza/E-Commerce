using ECommerce.Business.Abstract;
using ECommerce.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
                _categoryService = categoryService;
        }

        [HttpPost("addCategory")]
        public IActionResult AddCategory(Category category)
        {
            try
            {
                _categoryService.Add(category);
                return Ok("Successful");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("deleteCategory")]
        public IActionResult DeleteCategory(Category category)
        {
            try
            {
                _categoryService.Delete(category);
                return Ok("Successful");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("updateCategory")]
        public IActionResult UpdateCategory(Category category)
        {

            try
            {
                _categoryService.Update(category);
                return Ok("Successful");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("getAllCategory")]
        public IActionResult GetAllCategory()
        {

            try
            {
                var result=_categoryService.GetAll();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
