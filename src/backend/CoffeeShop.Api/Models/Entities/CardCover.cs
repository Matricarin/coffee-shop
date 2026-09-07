namespace CoffeeShop.Api.Models.Entities;

public sealed class CardCover
{
    public Guid Id { get; set; }
    public required string Title { get; set; }
    public List<string> Tags { get; set; } = [];
    public DateTime CreatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public long Popularity { get; set; }
    public required string ImageUri { get; set; }
}