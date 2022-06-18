using CrowdParlay.Application.Common.Abstractions;
using CrowdParlay.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CrowdParlay.Infrastructure;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        => services.AddSingleton<IUsernameGenerator, RandomUsernameGenerator>();
}
