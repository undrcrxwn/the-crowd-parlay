using CrowdParlay.Application.Common.Abstractions;

namespace CrowdParlay.Infrastructure.Services;

internal class RandomUsernameGenerator : IUsernameGenerator
{
    #region Words
    
    private static readonly string[] Adjectives =
    {
        "autumn", "hidden", "bitter", "misty", "silent", "empty", "dry", "dark", "summer", "icy", "delicate", "quiet",
        "white", "cool", "spring", "winter", "patient", "twilight", "dawn", "crimson", "blush", "chilly", "freezing",
        "blue", "shadowy", "thawing", "bitter", "icy", "dreamy", "truthful", "bold", "light", "floral", "restless",
        "polite", "long", "quiet", "cloudy", "silver", "round", "warm", "chilly", "icy", "shy", "cool", "spring",
        "winter", "patient", "twilight", "dawn", "crimson", "blush", "chilly", "freezing", "blue", "shadowy", "thawing",
        "bitter", "icy", "dreamy", "truthful", "bold", "light", "floral", "restless", "polite", "long", "quiet",
        "cloudy", "silver", "round", "warm", "chilly", "icy", "shy", "cool", "spring", "winter", "patient", "twilight",
        "dawn", "crimson", "blush", "chilly", "freezing", "blue", "shadowy", "thawing", "bitter", "icy", "dreamy",
        "truthful", "bold", "light", "floral", "restless", "polite", "long", "quiet", "cloudy", "silver", "round",
        "warm", "chilly", "icy", "shy", "cool", "spring", "winter", "patient", "twilight", "dawn", "crimson", "blush",
        "chilly", "freezing", "blue", "shadowy", "thawing", "bitter", "icy", "dreamy", "truthful", "bold", "light",
        "floral", "restless", "polite", "long", "quiet", "cloudy", "silver", "round", "warm", "chilly", "icy", "shy",
        "cool", "spring", "winter"
    };

    private static readonly string[] Nouns =
    {
        "cat", "dog", "rabbit", "lion", "tiger", "horse", "sheep", "pig", "cow", "goat", "chicken", "duck", "elephant",
        "bear", "zebra", "giraffe", "deer", "fox", "raccoon", "bird", "panda", "koala", "lizard", "turtle",
        "snake", "bug", "hippo", "owl", "bat", "bee", "beetle", "fish", "hamster", "sheep", "shark", "chicken",
        "rabbit", "turtle", "fish", "penguin", "zebra", "lion", "cat", "dog", "rabbit", "lion", "tiger", "horse",
        "sheep", "pig", "cow", "goat", "chicken", "duck", "elephant", "bear", "zebra", "giraffe", "deer", "fox",
        "raccoon", "bird", "panda", "koala", "lizard", "turtle", "snake", "bug", "hippo", "owl", "bat", "bee", "beetle",
        "fish", "hamster", "sheep", "shark", "chicken", "rabbit", "turtle", "fish", "penguin", "zebra", "lion", "cat",
        "dog", "rabbit", "lion", "tiger", "horse", "sheep", "pig", "cow", "goat", "chicken", "duck", "elephant", "bear",
        "zebra", "giraffe", "deer", "fox", "raccoon", "bird", "panda", "koala", "lizard", "turtle", "snake", "bug",
        "hippo", "owl", "bat", "bee", "beetle", "fish", "hamster", "sheep", "shark", "chicken", "rabbit", "turtle",
        "fish", "penguin"
    };

    #endregion

    private static readonly Random Random = new();
    
    public string GenerateUsername()
    {
        var adjective = GetRandomElement(Adjectives);
        var noun = GetRandomElement(Nouns);
        var postfix = Guid.NewGuid().ToString().Split('-').First();
        var username = $"{adjective}{noun}{postfix}";
        
        return username.Substring(0, Math.Min(20, username.Length));
    }
    
    private static T GetRandomElement<T>(IReadOnlyList<T> elements)
        => elements[Random.Next(elements.Count)];
}
