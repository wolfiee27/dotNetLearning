
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurents.Domain.Entities
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; } = 0;
         
        public int RestaurentID { get; set; }
    }
}
