using CrowdParlay.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CrowdParlay.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CrowdParlayController : AbpControllerBase
{
    protected CrowdParlayController()
    {
        LocalizationResource = typeof(CrowdParlayResource);
    }
}
