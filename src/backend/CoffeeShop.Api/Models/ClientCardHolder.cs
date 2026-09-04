namespace CoffeeShop.Api.Models;

public sealed class ClientCardHolder
{
    public Guid ClientId { get; init; }
    public Guid CardHolderId { get; init; }
}