using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace CrowdParlay.Data;

/* This is used if database provider does't define
 * ICrowdParlayDbSchemaMigrator implementation.
 */
public class NullCrowdParlayDbSchemaMigrator : ICrowdParlayDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
