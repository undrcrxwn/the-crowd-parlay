using System.ComponentModel.DataAnnotations;

namespace CrowdParlay.Infrastructure.Data.Annotations;

public sealed class UserNameOrEmailAddressAttribute : ValidationAttribute
{
    private readonly UserNameAttribute _userNameAttribute = new();
    private readonly EmailAddressAttribute _emailAddressAttribute = new();

    public UserNameOrEmailAddressAttribute()
        => ErrorMessage = "The value provided cannot be associated with either a username or an email address.";

    public override bool IsValid(object? value)
        => _userNameAttribute.IsValid(value) || _emailAddressAttribute.IsValid(value);
}
