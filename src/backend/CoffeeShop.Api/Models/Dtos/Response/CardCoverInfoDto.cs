namespace CoffeeShop.Api.Models.Dtos.Response;

public sealed record CardCoverInfoDto(Guid Id, string Title, List<string> Tags, string ImageUri);