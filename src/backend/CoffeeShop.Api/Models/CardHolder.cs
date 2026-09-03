namespace CoffeeShop.Api.Models;

public sealed class CardHolder
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public ClientUser User { get; set; }

    public List<Card> Cards { get; set; } = [];
}