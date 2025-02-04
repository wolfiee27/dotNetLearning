
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Restaurents.Infrastructure.Persistence;

namespace Restaurents.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration) {
            var connectionString = configuration.GetConnectionString("RestaurentsDb");
            services.AddDbContext<RestaurentDbContext>(options => options.UseSqlServer(connectionString));
        }
    }
}
