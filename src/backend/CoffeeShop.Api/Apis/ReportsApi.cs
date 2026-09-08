namespace CoffeeShop.Api.Apis;

public static class ReportsApi
{
    // TODO: продолжить корректировку
    public static IEndpointRouteBuilder MapReportsApi(this IEndpointRouteBuilder group)
    {
        group.MapGet("/users/activity", GetUsersActivityReportAsync)
            .WithName("Activity")
            .WithSummary("Активность пользователей")
            .WithDescription("Активность пользователей")
            .WithTags("Reports");

        group.MapGet("/cards/redemption-rate", GetRedemptionRateReportAsync)
            .WithName("Redemption")
            .WithSummary("Доля успешно погашенных бонусов")
            .WithDescription("Доля успешно погашенных бонусов")
            .WithTags("Reports");

        group.MapGet("/cards/retention-rate", GetRetentionRateReportAsync)
            .WithName("Retention")
            .WithSummary("Процент пользователей, возвращающихся за второй и последующими покупками с приложением")
            .WithDescription("Процент пользователей, возвращающихся за второй и последующими покупками с приложением")
            .WithTags("Reports");

        group.MapGet("/covers/rating", GetCoversRatingAsync)
            .WithName("Rating")
            .WithSummary("Рейтинг обложек")
            .WithDescription("Рейтинг обложек")
            .WithTags("Reports");

        return group;
    }

    private static async Task GetCoversRatingAsync(HttpContext context)
    {
        throw new NotImplementedException();
    }

    private static async Task GetRetentionRateReportAsync(HttpContext context)
    {
        throw new NotImplementedException();
    }

    private static async Task GetRedemptionRateReportAsync(HttpContext context)
    {
        throw new NotImplementedException();
    }

    private static async Task GetUsersActivityReportAsync(HttpContext context)
    {
        throw new NotImplementedException();
    }
}