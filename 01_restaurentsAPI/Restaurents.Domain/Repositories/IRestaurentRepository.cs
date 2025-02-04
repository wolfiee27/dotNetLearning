using Restaurents.Domain.Entities;

namespace Restaurents.Domain.Repositories;

public interface IRestaurentRepository
{
    Task<IEnumerable<Restaurent>> GetAllAsync();
}
