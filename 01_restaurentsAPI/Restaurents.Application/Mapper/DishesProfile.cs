using AutoMapper;
using Restaurents.Application.Dtos;
using Restaurents.Domain.Entities;

namespace Restaurents.Application.Mapper;

public class DishesProfile: Profile
{
    public DishesProfile()
    {
        CreateMap<Dish, DishDto>();
    }
}
