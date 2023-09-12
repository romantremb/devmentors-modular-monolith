using Infow.Shared.Abstractions.Commands;
using Infow.Shared.Abstractions.Time;
using Infow.Shared.Infrastructure.Commands;
using Infow.Shared.Infrastructure.Time;
using Microsoft.Extensions.DependencyInjection;

namespace Infow.Shared.Infrastructure;

internal static class Extensions
{
    public static IServiceCollection AddModularInfrastructure(this IServiceCollection services)
    {
        services.AddCommands()
                .AddSingleton<IClock, UtcClock>();
        
        return services;
    }
}