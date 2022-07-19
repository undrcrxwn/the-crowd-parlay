using CrowdParlay.Localization;
using Volo.Abp.Application.Services;

namespace CrowdParlay;

/* Inherit your application services from this class.
 */
public abstract class CrowdParlayAppService : ApplicationService
{
    protected CrowdParlayAppService()
    {
        LocalizationResource = typeof(CrowdParlayResource);
    }
}
