using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace CrowdParlay.Infrastructure.Data.Annotations;

public sealed class UserNameAttribute : ValidationAttribute
{
    public UserNameAttribute()
        => ErrorMessage = "Username can only contain A-Z, a-z, 0-9, _ and be 5 to 15 characters long.";
    
    public override bool IsValid(object? value)
        => value is string username && Regex.IsMatch(username, @"^[\w]{5,15}$");
}
