using CrowdParlay.Application.Common.Abstractions;

namespace CrowdParlay.Infrastructure.Services;

internal class RandomUsernameGenerator : IUsernameGenerator
{
    public string GenerateUsername() => Guid.NewGuid()
        .ToString()
        .Replace("-", string.Empty)
        .Substring(0, 15);
}
