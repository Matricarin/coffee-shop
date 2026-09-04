namespace CoffeeShop.Api.Endpoints;

public static class CoffeeShopApi
{
    public static WebApplication MapCoffeeShopEndpoints(this WebApplication app)
    {
        app.MapGroup("/auth").MapAuthGroups();
        app.MapGroup("/offers").MapOffersEndpoints();
        app.MapGroup("/cards").MapCardsEndpoints();
        app.MapGroup("/covers").MapCoversEndpoints();
        app.MapGroup("/reports").MapReportsEndpoints();
        return app;
    }

    private static IEndpointRouteBuilder MapOffersEndpoints(this IEndpointRouteBuilder group)
    {
        group.MapGet("/actual", () => "Получить актуальное скидочное предложение");
        group.MapPost("/new-offer", () => "Создаить скидочное предложение");
        group.MapPut("/offer", () => "Корректировать скидочное предложение");
        return group;
    }

    private static IEndpointRouteBuilder MapReportsEndpoints(this IEndpointRouteBuilder group)
    {
        group.MapGet("/users/activity", () => "Отчет активности пользователей");
        group.MapGet("/cards/purchases",
            () => "Соотношение между покупками с использованием бонусной системы и без использования");
        group.MapGet("/covers/rating", () => "Самые популярные обложки");
        return group;
    }

    private static IEndpointRouteBuilder MapCardsEndpoints(this IEndpointRouteBuilder group)
    {
        group.MapPost("/new-card", () => "Пользователь добавляет себе карточку при входе в систему");
        group.MapGet("/active-card", () => "Пользователь получает активную карточку");
        group.MapPatch("/cover", () => "Пользователь выбирает для карточки обложку");
        group.MapPut("/purchase", () => "Пользователь показывает qr для фиксирования покупки кофе");
        return group;
    }

    private static IEndpointRouteBuilder MapCoversEndpoints(this IEndpointRouteBuilder group)
    {
        group.MapPost("/new-cover", () => "Админ добавляет новую обложку в хранилище");
        group.MapGet("/list", () => "Получаем список обложек");
        group.MapGet("/{id}", (Guid id) => "Получаем выбранную обложку");
        group.MapDelete("/{id}", (Guid id) => "Админ удаляет обложку");
        return group;
    }

    private static IEndpointRouteBuilder MapAuthGroups(this IEndpointRouteBuilder group)
    {
        group.MapGroup("/admin").MapAdminAuthEndpoints();
        group.MapGroup("/clients").MapClientsAuthEndpoints();
        return group;
    }

    private static IEndpointRouteBuilder MapAdminAuthEndpoints(this IEndpointRouteBuilder group)
    {
        group.MapPost("/register", () => "Регистрация админа");
        group.MapPost("/login", () => "Админ входит в систему");
        return group;
    }

    private static IEndpointRouteBuilder MapClientsAuthEndpoints(this IEndpointRouteBuilder group)
    {
        group.MapPost("/register", () => "Регистрация клиента");
        group.MapPost("/login", () => "Клиент входит в приложение");
        group.MapPost("/confirm", () => "Подтверждаем вход по смс");
        return group;
    }
}