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
    public static void AddBlandCallUtilAsSingleton(this IServiceCollection services)
    {
        services.AddBlandClientAsSingleton();
        services.TryAddSingleton<IBlandCallUtil, BlandCallUtil>();
    }

    /// <summary>
    /// Adds <see cref="IBlandCallUtil"/> as a scoped service. <para/>
    /// </summary>
    public static void AddBlandCallUtilAsScoped(this IServiceCollection services)
    {
        services.AddBlandClientAsSingleton();
        services.TryAddScoped<IBlandCallUtil, BlandCallUtil>();
    }
}
