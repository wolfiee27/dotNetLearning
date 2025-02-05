namespace Restaurents.Application.Dtos;

public class DishDto
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public decimal Price { get; set; } = 0;
    public int? KiloCalories { get; set; }
    public int RestaurentID { get; set; }
}
