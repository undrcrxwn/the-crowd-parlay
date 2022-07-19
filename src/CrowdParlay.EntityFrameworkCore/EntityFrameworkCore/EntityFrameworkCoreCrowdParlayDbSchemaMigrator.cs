using System;
using System.Threading.Tasks;
using CrowdParlay.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.DependencyInjection;

namespace CrowdParlay.EntityFrameworkCore;

public class EntityFrameworkCoreCrowdParlayDbSchemaMigrator
    : ICrowdParlayDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreCrowdParlayDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the CrowdParlayDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<CrowdParlayDbContext>()
            .Database
            .MigrateAsync();
    }
}
