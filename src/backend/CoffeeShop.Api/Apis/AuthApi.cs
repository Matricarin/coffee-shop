namespace CoffeeShop.Api.Apis;

public static class AuthApi
{
    public static IEndpointRouteBuilder MapAuthGroups(this IEndpointRouteBuilder group)
    {
        group.MapGroup("/admin").MapAdminAuthApi();
        group.MapGroup("/clients").MapClientsAuthApi();
        return group;
    }

    private static IEndpointRouteBuilder MapAdminAuthApi(this IEndpointRouteBuilder group)
    {
        group.MapPost("/register", () => "Регистрация админа");
        group.MapPost("/login", () => "Админ входит в систему");
        return group;
    }

    private static IEndpointRouteBuilder MapClientsAuthApi(this IEndpointRouteBuilder group)
    {
        group.MapPost("/register", () => "Регистрация клиента");
        group.MapPost("/login", () => "Клиент входит в приложение");
        group.MapPost("/confirm", () => "Подтверждаем вход по смс");
        return group;
    }
}