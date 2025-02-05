using Restaurents.Domain.Entities;

namespace Restaurents.Application.Dtos;

public class RestaurentDto
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string Category { get; set; } = default!;
    public bool HasDelivery { get; set; }

    public string? City { get; set; }
    public string? Street { get; set; }
    public string? PostalCode { get; set; }
    public List<DishDto>? Dishes { get; set; } = new();

    public static RestaurentDto? FromEntity(Restaurent? restaurent)
    {   
        if (restaurent == null)
            return null;
        return new RestaurentDto
        {
            Id = restaurent.Id,
            Name = restaurent.Name,
            Description = restaurent.Description,
            Category = restaurent.Category,
            HasDelivery = restaurent.HasDelivery,
            City = restaurent.Address?.City,
            Street = restaurent.Address?.Street,
            PostalCode = restaurent.Address?.PostalCode,
        };
    }
}
