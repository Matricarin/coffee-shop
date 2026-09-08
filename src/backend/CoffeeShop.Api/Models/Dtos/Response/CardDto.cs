namespace CoffeeShop.Api.Models.Dtos.Response;

public record CardDto(Guid Id, Guid CoverId, Guid OfferId, bool IsFreeDrink, int AmountPurchases);