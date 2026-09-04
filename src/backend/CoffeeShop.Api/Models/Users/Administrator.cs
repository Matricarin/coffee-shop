namespace CoffeeShop.Api.Models.Users;

public sealed class Administrator : ApplicationUser
{
    public string? ImageUrl { get; set; }
}