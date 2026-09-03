using Microsoft.AspNetCore.Identity;

namespace CoffeeShop.Api.Models;

public abstract class ApplicationUser : IdentityUser<Guid>
{
    public DateTime CreatedDate { get; init; } = DateTime.Now;
    public bool IsActive { get; init; } = true;
}

public sealed class AdminUser : ApplicationUser
{
    public string? ImageUrl { get; set; }
}

public sealed class ClientUser : ApplicationUser
{
    public string? ImageUrl { get; set; }
}

public static class ApplicationRoles
{
    public const string Admin = "admin";
    public const string Client = "client";
    public static readonly string[] AvailableRoles = [Admin, Client];
}

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