namespace CoffeeShop.Api.Models;

public sealed class CardHolder
{
    public Guid Id { get; set; }

    public List<Card> Cards { get; set; } = [];
}