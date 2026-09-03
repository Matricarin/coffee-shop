namespace CoffeeShop.Api.Endpoints;

public static class CoffeeShopApi
{
    public static WebApplication MapCoffeeShopEndpoints(this WebApplication app)
    {
        app.MapGroup("/auth").MapAuthGroups();

        return app;
    }

    private static IEndpointRouteBuilder MapAuthGroups(this IEndpointRouteBuilder group)
    {
        group.MapGroup("/admin").MapAdminAuthEndpoints();

        group.MapGroup("/clients").MapClientsAuthEndpoints();

        return group;
    }

    private static IEndpointRouteBuilder MapAdminAuthEndpoints(this IEndpointRouteBuilder group)
    {
        group.MapPost("/register", () => "Admin registration");

        group.MapPost("/login", () => "Enter in admin panel");

        return group;
    }

    private static IEndpointRouteBuilder MapClientsAuthEndpoints(this IEndpointRouteBuilder group)
    {
        group.MapPost("/register", () => "App registration");

        group.MapPost("/login", () => "Enter in app");

        group.MapPost("/confirm", () => "Confirm enter");

        return group;
    }
}