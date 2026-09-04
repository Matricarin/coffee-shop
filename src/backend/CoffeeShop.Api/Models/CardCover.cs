namespace CoffeeShop.Api.Models;

public sealed class CardCover
{
    public Guid Id { get; set; }
    public string? Tag { get; set; }
    public required string ImageUrl { get; set; }
}