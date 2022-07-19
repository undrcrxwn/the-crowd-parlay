using CrowdParlay.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CrowdParlay.Permissions;

public class CrowdParlayPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CrowdParlayPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(CrowdParlayPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CrowdParlayResource>(name);
    }
}
