using CrowdParlay.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace CrowdParlay.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CrowdParlayEntityFrameworkCoreModule),
    typeof(CrowdParlayApplicationContractsModule)
    )]
public class CrowdParlayDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
