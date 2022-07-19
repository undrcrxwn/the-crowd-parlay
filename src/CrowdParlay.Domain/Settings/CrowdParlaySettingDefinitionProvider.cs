using Volo.Abp.Settings;

namespace CrowdParlay.Settings;

public class CrowdParlaySettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(CrowdParlaySettings.MySetting1));
    }
}
