using Restaurents.Application.Dtos;
using Restaurents.Domain.Entities;

namespace Restaurents.Application.Restaurents
{
    public interface IRestaurentsService
    {
        Task<IEnumerable<RestaurentDto>> GetAllRestaurents();
        Task<RestaurentDto> GetRestaurent(int id);
    }
}