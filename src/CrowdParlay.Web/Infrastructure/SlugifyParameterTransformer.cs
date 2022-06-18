using System.Text.RegularExpressions;

namespace CrowdParlay.Web.Infrastructure;

public class SlugifyParameterTransformer : IOutboundParameterTransformer
{
    // Slugify value
    public string? TransformOutbound(object? value) => value switch
    {
        null => null,
        _ => Regex.Replace(value.ToString(), "([a-z])([A-Z])", "$1-$2").ToLower()
    };
}
