using AsianKitchen.Application.Common.Interfaces;
using AsianKitchen.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AsianKitchen.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>();
        return services;
    }
}