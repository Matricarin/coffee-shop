namespace CoffeeShop.Api.Apis;

public static class OffersApi
{
    public static IEndpointRouteBuilder MapOffersApi(this IEndpointRouteBuilder group)
    {
        group.MapGet("/actual", () => "Получить актуальное скидочное предложение");
        group.MapPost("/new-offer", () => "Создаить скидочное предложение");
        group.MapPut("/offer", () => "Корректировать скидочное предложение");
        return group;
    }
}