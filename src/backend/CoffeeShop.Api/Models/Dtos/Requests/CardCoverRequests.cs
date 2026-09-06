namespace CoffeeShop.Api.Models.Dtos.Requests;

public sealed record CreateCardCoverRequest(string Title, List<string> Tags);

public sealed record UpdateCardCoverRequest(string Title, List<string> Tags);