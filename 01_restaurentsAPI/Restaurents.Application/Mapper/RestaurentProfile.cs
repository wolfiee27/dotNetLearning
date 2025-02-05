using AutoMapper;
using Restaurents.Application.Dtos;
using Restaurents.Domain.Entities;

namespace Restaurents.Application.Mapper;

public class RestaurentProfile: Profile
{
    public RestaurentProfile()
    {
        CreateMap<Restaurent, RestaurentDto>()
            .ForMember(destination => destination.City,
                opt => opt.MapFrom(src => src.Address == null ? null : src.Address.City))
            .ForMember(d => d.Street,
                opt => opt.MapFrom(src => src.Address == null ? null : src.Address.City))
            .ForMember(d => d.PostalCode,
                opt => opt.MapFrom(src => src.Address == null ? null : src.Address.PostalCode))
            .ForMember(d => d.Dishes, opt => opt.MapFrom(src => src.Dishes));
    }
}
