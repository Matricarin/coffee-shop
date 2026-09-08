using CoffeeShop.Api.Models.Dtos.Response;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace CoffeeShop.Api.Apis;

public static class CardsApi
{
    public static IEndpointRouteBuilder MapCardsApi(this IEndpointRouteBuilder group)
    {
        group.MapPost("/new-card", PostCard)
            .WithName("CreateCard")
            .WithSummary("Создать новую карточку для пользователя")
            .WithDescription("Создать новую карточку для пользователя")
            .WithTags("Cards");

        group.MapGet("/active-card", GetActiveCard)
            .WithName("ActiveCard")
            .WithSummary("Получить активную карточку пользователя")
            .WithDescription("Получить активную карточку пользователя")
            .WithTags("Cards");

        group.MapPatch("/cover", PatchCardCover)
            .WithName("SetCardCover")
            .WithSummary("Задать карточке новую обложку")
            .WithDescription("Задать карточке новую обложку")
            .WithTags("Cards");

        group.MapPut("/purchase", PutPurchase)
            .WithName("MakePurchase")
            .WithSummary("Совершить покупку с фиксацией бонуса")
            .WithDescription("Совершить покупку с фиксацией бонуса")
            .WithTags("Cards");

        return group;
    }

    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest,
        "application/problem+json")]
    [ProducesResponseType<ProblemDetails>(StatusCodes.Status500InternalServerError,
        "application/problem+json")]
    private static async Task<Results<Ok<CardDto>, InternalServerError<ProblemDetails>, BadRequest<ProblemDetails>>>
        PutPurchase
        (
            [Description("Id карточки")] [FromQuery]
            Guid cardId,
            [Description("Id обложки")] [FromQuery]
            Guid coverId
        )
    {
        throw new NotImplementedException();
    }

    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest,
        "application/problem+json")]
    private static async Task<Results<Ok<CardDto>, NotFound, BadRequest<ProblemDetails>>>
        PatchCardCover
        (
            [Description("Id карточки")] [FromQuery]
            Guid cardId,
            [Description("Id обложки")] [FromQuery]
            Guid coverId
        )
    {
        throw new NotImplementedException();
    }

    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest,
        "application/problem+json")]
    private static async Task<Results<Ok<CardDto>, NotFound, BadRequest<ProblemDetails>>>
        GetActiveCard
        (
            [Description("Id клиента")] [FromQuery]
            Guid clientId
        )
    {
        throw new NotImplementedException();
    }

    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest,
        "application/problem+json")]
    private static async Task<Created>
        PostCard
        (
            [Description("Id клиента")] [FromQuery]
            Guid clientId
        )
    {
        throw new NotImplementedException();
    }
}