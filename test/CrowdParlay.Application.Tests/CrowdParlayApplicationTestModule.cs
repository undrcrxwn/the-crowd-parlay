using Volo.Abp.Modularity;

namespace CrowdParlay;

[DependsOn(
    typeof(CrowdParlayApplicationModule),
    typeof(CrowdParlayDomainTestModule)
    )]
public class CrowdParlayApplicationTestModule : AbpModule
{

}
