namespace CoffeeShop.Api.Models.Dtos.Requests;

public record RegisterAdminRequest(string Name, string Email, string Password);