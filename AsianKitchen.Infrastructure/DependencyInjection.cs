using AsianKitchen.Application.Common.Interfaces;
using AsianKitchen.Application.Common.Persistence;
using AsianKitchen.Infrastructure.Services.Authentication;
using AsianKitchen.Infrastructure.Services.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace AsianKitchen.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, 
                                Microsoft.Extensions.Configuration.ConfigurationManager configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));

        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddScoped<IUserRepository, UserRepository>();
        return services;
    }
}