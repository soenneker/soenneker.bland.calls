using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Bland.Calls.Abstract;
using Soenneker.Bland.Client.Registrars;

namespace Soenneker.Bland.Calls.Registrars;

/// <summary>
/// A .NET typesafe implementation of Bland.ai's Calls API
/// </summary>
public static class BlandCallUtilRegistrar
{
    /// <summary>
    /// Adds <see cref="IBlandCallUtil"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddBlandCallUtilAsSingleton(this IServiceCollection services)
    {
        services.AddBlandClientUtilAsSingleton();
        services.TryAddSingleton<IBlandCallUtil, BlandCallUtil>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="IBlandCallUtil"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddBlandCallUtilAsScoped(this IServiceCollection services)
    {
        services.AddBlandClientUtilAsSingleton();
        services.TryAddScoped<IBlandCallUtil, BlandCallUtil>();

        return services;
    }
}
