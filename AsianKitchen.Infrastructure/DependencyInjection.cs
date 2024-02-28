using AsianKitchen.Application.Common.Interfaces;
using AsianKitchen.Infrastructure.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace AsianKitchen.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, 
                                Microsoft.Extensions.Configuration.ConfigurationManager configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));

        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        return services;
    }
}