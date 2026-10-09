using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace OmniReserve.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services, 
        IConfiguration configuration)
    {
        // Aquí se registrarán la base de datos, repositorios y autenticación en el futuro.

        return services;
    }
}