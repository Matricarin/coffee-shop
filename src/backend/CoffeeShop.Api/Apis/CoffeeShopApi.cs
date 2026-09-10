namespace CoffeeShop.Api.Apis;

public static class CoffeeShopApi
{
    public static IEndpointRouteBuilder MapCoffeeShopApi(this IEndpointRouteBuilder app)
    {
        app.MapAuthGroups();

        app.MapGroup("/api/offers").MapOffersApi();

        app.MapGroup("/api/cards").MapCardsApi();

        app.MapGroup("/api/covers").MapCardCoversApi();

        app.MapGroup("/api/reports").MapReportsApi();

        return app;
    }
}