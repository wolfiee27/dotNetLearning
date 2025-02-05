﻿using Microsoft.EntityFrameworkCore;
using Restaurents.Domain.Entities;
using Restaurents.Domain.Repositories;
using Restaurents.Infrastructure.Persistence;

namespace Restaurents.Infrastructure.Repositories;

internal class RestaurentsRepositories(RestaurentDbContext dbContext) : IRestaurentRepository
{
    public async Task<IEnumerable<Restaurent>> GetAllAsync()
    {
        var restaurents = await dbContext.Restaurents.Include(r => r.Dishes).ToListAsync();
        return restaurents;
    }

    public async Task<Restaurent?> GetRestaurentByIdAsync(int id)
    {
        var restaurent = await dbContext.Restaurents.Include(r => r.Dishes).Where(restaurent => restaurent.Id == id).FirstOrDefaultAsync();
        return restaurent;
    }
}
