using CoffeeShop.Api.Models.Dtos.Requests;
using CoffeeShop.Api.Models.Dtos.Response;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace CoffeeShop.Api.Apis;

public static class CardCoversApi
{
    public static IEndpointRouteBuilder MapCardCoversApi(this IEndpointRouteBuilder group)
    {
        group.MapPost("/new-cover", PostNewCardCoverAsync);

        group.MapPut("/", PutCardCoverAsync);

        group.MapGet("/list", GetListAsync);
        group.MapGet("/{coverId:guid}", GetCardCoverAsync);

        group.MapGet("/files", GetListFilesAsync);
        group.MapGet("/file/{coverId:guid}", GetCardCoverFileAsync);

        group.MapDelete("/{coverId:guid}", DeleteCardCoverAsync);
        return group;
    }

    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest,
        "application/problem+json")]
    private static async Task<Results<Ok<CardCoverInfoDto>, NotFound, BadRequest<ProblemDetails>>>
        GetCardCoverAsync
        (
            HttpContext context,
            [Description("Id обложки для карточки")]
            Guid coverId
        )
    {
        throw new NotImplementedException();
    }

    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest,
        "application/problem+json")]
    private static async Task<Ok<List<CardCoverInfoDto>>>
        GetListAsync()
    {
        throw new NotImplementedException();
    }


    private static async Task<Results<NotFound, NoContent>>
        DeleteCardCoverAsync
        (
            HttpContext context,
            [Description("Id удаляемой карточки")] Guid coverId
        )
    {
        throw new NotImplementedException();
    }


    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest, "application/problem+json")]
    private static async Task<Created>
        PostNewCardCoverAsync
        (
            HttpContext context,
            [Description("Данные о создаваемой обложке")]
            CreateCardCoverRequest request
        )
    {
        throw new NotImplementedException();
    }

    private static async Task<Results<Created, BadRequest<ProblemDetails>, NotFound<ProblemDetails>>>
        PutCardCoverAsync
        (
            HttpContext context,
            [Description("Данные для обновления обложки")]
            UpdateCardCoverRequest request
        )
    {
        throw new NotImplementedException();
    }

    #region BUG: временно возвращаем строки путей к файлам, а не сами файлы

    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest,
        "application/problem+json")]
    private static async Task<Ok<List<string>>>
        GetListFilesAsync()
    {
        throw new NotImplementedException();
    }

    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest,
        "application/problem+json")]
    private static async Task<Results<Ok<string>, NotFound, BadRequest<ProblemDetails>>>
        GetCardCoverFileAsync
        (
            HttpContext context,
            [Description("Id обложки для карточки")]
            Guid coverId
        )
    {
        throw new NotImplementedException();
    }

    #endregion
}