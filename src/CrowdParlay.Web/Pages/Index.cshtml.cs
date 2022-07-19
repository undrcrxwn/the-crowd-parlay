using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace CrowdParlay.Web.Pages;

public class IndexModel : CrowdParlayPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
