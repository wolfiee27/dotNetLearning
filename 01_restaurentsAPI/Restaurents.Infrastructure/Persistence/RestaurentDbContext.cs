using Microsoft.EntityFrameworkCore;
using Restaurents.Domain.Entities;

namespace Restaurents.Infrastructure.Persistence
{
    public class RestaurentDbContext(DbContextOptions<RestaurentDbContext> options) : DbContext(options)
    {
        public DbSet<Restaurent> Restaurents { get; set; }
        public DbSet<Dish> Dishes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Restaurent>()
                .OwnsOne(r => r.Address);

            modelBuilder.Entity<Restaurent>()
                .HasMany(r => r.Dishes)
                .WithOne()
                .HasForeignKey(d => d.RestaurentID);
        }
    }
}
