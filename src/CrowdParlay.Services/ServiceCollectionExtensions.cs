using CrowdParlay.Services.Abstractions;
using CrowdParlay.Services.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace CrowdParlay.Services;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddRandomUsernameGenerator(this IServiceCollection services)
        => services.AddTransient<IUsernameGenerator, RandomUsernameGenerator>();
}
