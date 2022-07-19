using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace CrowdParlay;

[Dependency(ReplaceServices = true)]
public class CrowdParlayBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "CrowdParlay";
}
