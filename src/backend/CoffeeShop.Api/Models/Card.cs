namespace CoffeeShop.Api.Models;

public class Card
{
    public Guid Id { get; set; }
    public Guid CoverId { get; set; }
    public CardCover Cover { get; set; }
    public bool IsActive { get; set; } = true;
    public bool IsFreeDrinkAvailable { get; set; } = false;
    public int TargetAmountOfPurchase { get; set; }
    public int CurrentAmountOfPurchase { get; set; }
}