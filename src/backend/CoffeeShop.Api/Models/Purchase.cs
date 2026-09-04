namespace CoffeeShop.Api.Models;

public sealed class Purchase
{
    public Guid Id { get; set; }
    public Guid ExternalPurchaseId { get; set; }
    public Guid ClientId { get; set; }
    public Guid? CardId { get; set; }
    public bool IsBonusUsed { get; set; }
    public DateTime CreatedAt { get; set; }
}