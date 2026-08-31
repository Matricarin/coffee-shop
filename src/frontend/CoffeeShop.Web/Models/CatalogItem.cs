namespace CoffeeShop.Web.Models;

public sealed record CatalogItem(
    Guid Id,
    string Name,
    string Description,
    decimal Price,
    string PictureUrl
);