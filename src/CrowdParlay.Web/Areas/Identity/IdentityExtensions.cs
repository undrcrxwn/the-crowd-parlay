﻿using CrowdParlay.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;

namespace CrowdParlay.Web.Areas.Identity;

public static class IdentityExtensions
{
    public static async Task<ApplicationUser> FindByUserNameOrEmailAsync(
        this UserManager<ApplicationUser> userManager, string usernameOrEmail)
    {
        return usernameOrEmail.Contains("@")
            ? await userManager.FindByEmailAsync(usernameOrEmail)
            : await userManager.FindByNameAsync(usernameOrEmail);
    }
}
