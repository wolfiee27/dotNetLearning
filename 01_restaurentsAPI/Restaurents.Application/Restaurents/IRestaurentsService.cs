﻿using Restaurents.Domain.Entities;

namespace Restaurents.Application.Restaurents
{
    internal interface IRestaurentsService
    {
        Task<IEnumerable<Restaurent>> GetAllRestaurents();
        Task<Restaurent> GetRestaurent(int id);
    }
}