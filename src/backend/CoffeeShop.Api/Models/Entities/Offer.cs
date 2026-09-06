namespace CoffeeShop.Api.Models.Entities;

public sealed class Offer
{
    public Guid Id { get; set; }

    public int TargetAmount { get; set; }

    public bool IsActual { get; set; }
}