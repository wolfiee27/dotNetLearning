
namespace Restaurents.Domain.Entities
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public decimal price { get; set; } 

        public int RestaurentID { get; set; }
    }
}
