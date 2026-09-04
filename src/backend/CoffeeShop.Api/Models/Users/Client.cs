namespace CoffeeShop.Api.Models.Users;

public sealed class Client : ApplicationUser
{
    public string? ImageUrl { get; set; }
}