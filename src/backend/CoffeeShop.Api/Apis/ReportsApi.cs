namespace CoffeeShop.Api.Apis;

public static class ReportsApi
{
    public static IEndpointRouteBuilder MapReportsApi(this IEndpointRouteBuilder group)
    {
        group.MapGet("/users/activity", () => "Отчет активности пользователей");
        group.MapGet("/cards/purchases",
            () => "Соотношение между покупками с использованием бонусной системы и без использования");
        group.MapGet("/covers/rating", () => "Самые популярные обложки");
        return group;
    }
}