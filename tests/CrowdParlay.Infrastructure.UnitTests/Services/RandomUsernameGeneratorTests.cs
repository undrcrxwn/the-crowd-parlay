using System;
using System.Linq;
using CrowdParlay.Infrastructure.Data.Annotations;
using CrowdParlay.Infrastructure.Services;
using Xunit;

namespace CrowdParlay.Infrastructure.UnitTests.Services;

public class RandomUsernameGeneratorTests
{
    [Fact]
    public void GenerateUsername_ReturnsRandomValues()
    {
        var usernameGenerator = new RandomUsernameGenerator();

        var usernames = Enumerable.Range(0, 100_000)
            .Select(_ => usernameGenerator.GenerateUsername());
        
        var allUnique = usernames
            .GroupBy(x => x)
            .All(x => x.Count() == 1);

        Assert.True(allUnique);
    }
    
    [Fact]
    public void GenerateUsername_ReturnsValidUsernames()
    {
        var usernameGenerator = new RandomUsernameGenerator();
        var usernameAttribute = new UserNameAttribute();

        var usernames = Enumerable.Range(0, 100_000)
            .Select(_ => usernameGenerator.GenerateUsername());

        var allValid = usernames
            .All(x => usernameAttribute.IsValid(x));
        
        Assert.True(allValid);
    }
}
