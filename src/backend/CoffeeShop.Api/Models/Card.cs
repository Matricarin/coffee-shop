namespace CoffeeShop.Api.Models;

public class Card
{
    public Guid Id { get; set; }
    public Guid ClientId { get; set; }
    public Guid OfferId { get; set; }
    public required Offer Offer { get; set; }
    public Guid CoverId { get; set; }
    public CardCover? Cover { get; set; }
    public bool IsActive { get; set; } = true;
    public bool IsFreeDrinkAvailable { get; set; } = false;
    public List<Purchase> PurchaseList { get; set; } = [];
}