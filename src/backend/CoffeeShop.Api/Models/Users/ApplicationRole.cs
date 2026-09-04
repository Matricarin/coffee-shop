using Microsoft.AspNetCore.Identity;

namespace CoffeeShop.Api.Models.Users;

public sealed class ApplicationRole : IdentityRole<Guid>
{
    public ApplicationRole(string roleName) : base(roleName)
    {
        if (string.IsNullOrWhiteSpace(roleName))
        {
            throw new ArgumentNullException(nameof(roleName));
        }

        if (!ApplicationRoles.AvailableRoles.Contains(roleName))
        {
            throw new ArgumentException("Неизвестная роль", nameof(roleName));
        }
    }
}