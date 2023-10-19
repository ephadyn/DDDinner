using DDDinner.Application.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace DDDinner.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services) {
        services.AddScoped<IAuthenticationService, AuthenticationService>();

        return services;
    }
}
