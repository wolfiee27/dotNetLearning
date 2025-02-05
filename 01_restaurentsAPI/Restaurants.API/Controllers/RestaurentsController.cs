using Microsoft.AspNetCore.Mvc;
using Restaurents.Application.Restaurents;
namespace Restaurants.API.Controllers
{
    [ApiController]
    [Route("api/restaurents")]
    public class RestaurentsController(IRestaurentsService restaurentsService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var restaurants = await restaurentsService.GetAllRestaurents(); 
            return Ok(restaurants);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetRestaurant(int id)
        {
            var restaurent = await restaurentsService.GetRestaurent(id);
            if (restaurent == null) {
                return NotFound($"there is no restaurant witht the id: {id}");
            }
            return Ok(restaurent);
        }
    }
}
