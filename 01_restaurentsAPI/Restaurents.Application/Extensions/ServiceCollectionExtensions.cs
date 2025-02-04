using Microsoft.Extensions.DependencyInjection;
using Restaurents.Application.Restaurents;

namespace Restaurents.Application.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IRestaurentsService, RestaurentsService>();
    }
}
