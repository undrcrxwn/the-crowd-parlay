using CrowdParlay.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace CrowdParlay.Web.Pages;

public abstract class CrowdParlayPageModel : AbpPageModel
{
    protected CrowdParlayPageModel()
    {
        LocalizationResourceType = typeof(CrowdParlayResource);
    }
}
