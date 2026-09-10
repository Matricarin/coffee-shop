using CoffeeShop.Api.Models.Dtos.Requests;
using CoffeeShop.Api.Models.Dtos.Response;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace CoffeeShop.Api.Apis;

public static class OffersApi
{
    public static IEndpointRouteBuilder MapOffersApi(this IEndpointRouteBuilder group)
    {
        group.MapGet("/actual", GetActualOfferAsync)
            .WithName("ActualOffer")
            .WithSummary("Акутальное скидочное предложение")
            .WithDescription("Акутальное скидочное предложение")
            .WithTags("Offers");

        group.MapPost("/new-offer", PostNewOfferAsync)
            .WithName("CreateOffer")
            .WithSummary("Создать новое скидочное предложение")
            .WithDescription("Создать новое скидочное предложение")
            .WithTags("Offers");

        group.MapPut("/offer", PutOfferAsync)
            .WithName("UpdateOffer")
            .WithSummary("Обновить скидочное предложение")
            .WithDescription("Обновить скидочное предложение")
            .WithTags("Offers");

        return group;
    }

    [ProducesResponseType<ProblemDetails>(StatusCodes.Status404NotFound, 
        "application/problem+json")]
    private static async Task<Results<Ok<OfferDto>, NotFound<ProblemDetails>>>
        GetActualOfferAsync()
    {
        throw new NotImplementedException();
    }

    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest, 
        "application/problem+json")]
    private static async Task<Created<OfferDto>>
        PostNewOfferAsync
        (
            [Description("Данные о создаваемом предложении")]
            OfferRequest request
        )
    {
        throw new NotImplementedException();
    }

    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest, 
        "application/problem+json")]
    [ProducesResponseType<ProblemDetails>(StatusCodes.Status404NotFound,
        "application/problem+json")]
    private static async Task<Results<Created, BadRequest<ProblemDetails>, NotFound<ProblemDetails>>>
        PutOfferAsync
        (
            [Description("Данные о корректируемом предложении")]
            OfferRequest request
        )
    {
        throw new NotImplementedException();
    }
}