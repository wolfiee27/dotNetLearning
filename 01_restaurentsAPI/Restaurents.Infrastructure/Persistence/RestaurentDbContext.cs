using Microsoft.EntityFrameworkCore;
using Restaurents.Domain.Entities;

namespace Restaurents.Infrastructure.Persistence
{
    public class RestaurentDbContext : DbContext
    {
        public DbSet<Restaurent> Restaurents { get; set; }
        public DbSet<Dish> Dishes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=RestaurantsDb;Trusted_Connection=True;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Restaurent>()
                .OwnsOne(r => r.Address);

            modelBuilder.Entity<Restaurent>()
                .HasMany(r => r.Dishes)
                .WithOne()
                .HasForeignKey(d => d.RestaurentID);
        }
    }
}
