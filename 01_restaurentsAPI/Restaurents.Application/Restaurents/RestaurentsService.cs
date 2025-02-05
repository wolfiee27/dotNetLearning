using Microsoft.Extensions.Logging;
using Restaurents.Application.Dtos;
using Restaurents.Domain.Repositories;
namespace Restaurents.Application.Restaurents;
public class RestaurentsService(IRestaurentRepository restaurentRepository,
    ILogger<RestaurentsService> logger) : IRestaurentsService
{
    public async Task<IEnumerable<RestaurentDto?>> GetAllRestaurents()
    {
        logger.LogInformation("getting all restaurants");
        var restaurants = await restaurentRepository.GetAllAsync();
        var restaurentDtos = restaurants.Select(r => RestaurentDto.FromEntity(r));
        return restaurentDtos;
    }

    public async Task<RestaurentDto?> GetRestaurent(int id)
    {
        logger.LogInformation($"getting restaurant with id: {id}");
        var restaurant = await restaurentRepository.GetRestaurentByIdAsync(id);
        var restaurentDto = RestaurentDto.FromEntity(restaurant);
        return restaurentDto;
    }

}

