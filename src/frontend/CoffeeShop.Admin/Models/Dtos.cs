namespace CoffeeShop.Admin.Models;

public sealed record RegisterDto(string Name, string Email, string Password);

public sealed record LoginDto(string Email, string Password);