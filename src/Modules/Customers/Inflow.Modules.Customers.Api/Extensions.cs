using Inflow.Modules.Customers.Core;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Inflow.Modules.Customers.Api;

internal static class Extensions
{
    public static IServiceCollection AddCustomersModule(this IServiceCollection services)
    {
        services.AddCore();
        
        return services;
    }

    public static IApplicationBuilder UseCustomersModule(this IApplicationBuilder app)
    {
        return app;
    }
}