namespace CoffeeShop.Api.Apis;

public static class CardsApi
{
    public static IEndpointRouteBuilder MapCardsApi(this IEndpointRouteBuilder group)
    {
        group.MapPost("/new-card", () => "Пользователь добавляет себе карточку при входе в систему");
        group.MapGet("/active-card", () => "Пользователь получает активную карточку");
        group.MapPatch("/cover", () => "Пользователь выбирает для карточки обложку");
        group.MapPut("/purchase", () => "Пользователь показывает qr для фиксирования покупки кофе");
        return group;
    }
}