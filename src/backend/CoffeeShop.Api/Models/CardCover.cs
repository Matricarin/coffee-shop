namespace CoffeeShop.Api.Models;

public sealed class CardCover
{
    public Guid Id { get; set; }
    public required string Title { get; set; }
    public string? Tags { get; set; }
    public DateTime CreatedAt { get; set; }
    public long Popularity { get; set; }
    public required string ImageUrl { get; set; }
}