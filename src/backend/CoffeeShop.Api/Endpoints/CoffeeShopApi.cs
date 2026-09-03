namespace CoffeeShop.Api.Endpoints;

public static class CoffeeShopApi
{
    public static WebApplication MapCoffeeShopEndpoints(this WebApplication app)
    {
        app.MapGroup("/auth").MapAuthGroups();
        app.MapGroup("/cards");
        app.MapGroup("/covers").MapCoversEndpoints();

        return app;
    }

    private static IEndpointRouteBuilder MapCoversEndpoints(this IEndpointRouteBuilder group)
    {
        group.MapPost("/new-cover", () => "Админ добавляет новую обложку в хранилище");
        group.MapGet("/list", () => "Получаем список обложек");
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