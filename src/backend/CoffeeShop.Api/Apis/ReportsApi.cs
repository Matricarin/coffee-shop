using CoffeeShop.Api.Models.Reports;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace CoffeeShop.Api.Apis;

public static class ReportsApi
{
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

    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest,
        "application/problem+json")]
    private static async Task<Ok<CoversRatingReport>>
        GetCoversRatingAsync
        (
            [Description("От")] [FromQuery] DateOnly from,
            [Description("До")] [FromQuery] DateOnly to
        )
    {
        throw new NotImplementedException();
    }

    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest,
        "application/problem+json")]
    private static async Task<Ok<RetentionRateReport>>
        GetRetentionRateReportAsync
        (
            [Description("От")] [FromQuery] DateOnly from,
            [Description("До")] [FromQuery] DateOnly to
        )
    {
        throw new NotImplementedException();
    }

    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest,
        "application/problem+json")]
    private static async Task<Ok<RedemptionRateReport>>
        GetRedemptionRateReportAsync
        (
            [Description("От")] [FromQuery] DateOnly from,
            [Description("До")] [FromQuery] DateOnly to
        )
    {
        throw new NotImplementedException();
    }

    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest,
        "application/problem+json")]
    private static async Task<Ok<UsersActivityReport>>
        GetUsersActivityReportAsync
        (
            [Description("От")] [FromQuery] DateOnly from,
            [Description("До")] [FromQuery] DateOnly to
        )
    {
        throw new NotImplementedException();
    }
}