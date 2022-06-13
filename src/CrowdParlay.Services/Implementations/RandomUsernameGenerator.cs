using CrowdParlay.Services.Abstractions;

namespace CrowdParlay.Services.Implementations;

public class RandomUsernameGenerator : IUsernameGenerator
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
        var adjective = GetRandomWord(Adjectives);
        var noun = GetRandomWord(Nouns);
        var number = Random.Next(100, 1000);
        
        return $"{adjective}{noun}{number}";
    }
    
    private static string GetRandomWord(IReadOnlyList<string> words)
        => words[Random.Next(words.Count)];
}
