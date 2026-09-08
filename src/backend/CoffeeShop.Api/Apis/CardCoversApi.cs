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
        group.MapPost("/new-cover", PostNewCardCoverAsync)
            .WithName("CreateCover")
            .WithSummary("Создать обложку для карточки")
            .WithDescription("Создать обложку для карточки")
            .WithTags("Covers");

        group.MapPut("/", PutCardCoverAsync)
            .WithName("UpdateCover")
            .WithSummary("Обновить или создать обложку для карточки")
            .WithDescription("Обновить или создать обложек для карточки")
            .WithTags("Covers");

        group.MapGet("/list", GetListAsync)
            .WithName("CoversList")
            .WithSummary("Список обложек для карточек")
            .WithDescription("Получить список обложек для карточек")
            .WithTags("Covers");

        group.MapGet("/{coverId:guid}", GetCardCoverAsync)
            .WithName("Cover")
            .WithSummary("Обложка для карточки")
            .WithDescription("Получить обложку для карточки")
            .WithTags("Covers");

        group.MapGet("/files", GetListFilesAsync)
            .WithName("CoversFilesList")
            .WithSummary("Список файлов обложек для карточек")
            .WithDescription("Получить список файлов обложек для карточек")
            .WithTags("Covers");

        group.MapGet("/file/{coverId:guid}", GetCardCoverFileAsync)
            .WithName("CoverFile")
            .WithSummary("Файл обложки для карточки")
            .WithDescription("Получить файл обложки для карточки")
            .WithTags("Covers");

        group.MapDelete("/{coverId:guid}", DeleteCardCoverAsync)
            .WithName("DeleteCover")
            .WithSummary("Удалить обложку для карточки")
            .WithDescription("Удалить обложку для карточки")
            .WithTags("Covers");

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