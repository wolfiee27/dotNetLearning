using Microsoft.Extensions.Logging;
using Restaurents.Domain.Entities;
using Restaurents.Domain.Repositories;
namespace Restaurents.Application.Restaurents;
internal class RestaurentsService(IRestaurentRepository restaurentRepository,
    ILogger<RestaurentsService> logger) : IRestaurentsService
{
    public async Task<IEnumerable<Restaurent>> GetAllRestaurents()
    {
        logger.LogInformation("getting all restaurants");
        var restaurants = await restaurentRepository.GetAllAsync();
        return restaurants;
    }

    public async Task<Restaurent> GetRestaurent(int id)
    {
        logger.LogInformation($"getting restaurant with id: {id}");
        var restaurant = await restaurentRepository.GetRestaurentByIdAsync(id);
        return restaurant;
    }

}

