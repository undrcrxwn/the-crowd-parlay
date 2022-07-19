using CrowdParlay.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace CrowdParlay;

[DependsOn(
    typeof(CrowdParlayEntityFrameworkCoreTestModule)
    )]
public class CrowdParlayDomainTestModule : AbpModule
{

}
