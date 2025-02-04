using Microsoft.EntityFrameworkCore;
using Restaurents.Domain.Entities;
using Restaurents.Domain.Repositories;
using Restaurents.Infrastructure.Persistence;

namespace Restaurents.Infrastructure.Repositories;

internal class RestaurentsRepositories(RestaurentDbContext dbContext) : IRestaurentRepository
{
    public async Task<IEnumerable<Restaurent>> GetAllAsync()
    {
        var restaurents = await dbContext.Restaurents.ToListAsync();
        return restaurents;
    }
}
