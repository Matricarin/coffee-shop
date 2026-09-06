using CoffeeShop.Api.Models.Dtos.Response;
using CoffeeShop.Api.Services.Contracts;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace CoffeeShop.Api.Apis;

public static class CardCoversApi
{
    public static IEndpointRouteBuilder MapCardCoversApi(this IEndpointRouteBuilder group)
    {
        group.MapPost("/new-cover", () => "Админ добавляет новую обложку");
        group.MapPut("/{id}", () => "Админ редактирует обложку или добавляет новую");
        group.MapGet("/list", () => "Получаем список обложек");
        group.MapGet("/{coverId:guid}", GetCoverInfoById);
        group.MapGet("/files", () => "Получаем набор файлов карточек");
        group.MapGet("/file", () => "Получаем файл каорточки");
        group.MapDelete("/{id}", (Guid id) => "Админ удаляет обложку");
        return group;
    }

    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest,
        "application/problem+json")]
    private static Task<Results<Ok<CardCoverInfoDto>, NotFound, BadRequest<ProblemDetails>>>
        GetCoverInfoById
        (
            HttpContext context,
            [AsParameters] ICardCoverService service,
            [Description("Id обложки для карточки")]
            Guid coverId
        )
    {
        throw new NotImplementedException();
    }
}