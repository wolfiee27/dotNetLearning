using Microsoft.AspNetCore.Mvc;
using Restaurents.Domain.Repositories;
using System.Reflection.Metadata.Ecma335;

namespace Restaurants.API.Controllers
{
    [ApiController]
    [Route("api/restaurents")]
    public class RestaurentsController(IRestaurentRepository restaurentsService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var restaurants = await restaurentsService.GetAllAsync(); 
            return Ok(restaurants);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetRestaurant(int id)
        {
            var restaurent = await restaurentsService.GetRestaurentByIdAsync(id);
            if (restaurent == null) {
                return NotFound($"there is no restaurant witht the id: {id}");
            }
            return Ok(restaurent);
        }
    }
}
