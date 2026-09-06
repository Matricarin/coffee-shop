using Microsoft.AspNetCore.Identity;

namespace CoffeeShop.Api.Models.Users;

public abstract class ApplicationUser : IdentityUser<Guid>
{
    public DateTime CreatedDate { get; init; } = DateTime.Now;
    public bool IsActive { get; init; } = true;
}