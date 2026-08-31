namespace CoffeeShop.Web.Models;

public sealed record DrinkItem(
    Guid Id,
    string Name,
    string Description,
    decimal Price,
    string PictureUrl
);