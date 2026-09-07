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
        group.MapGet("/actual", GetActualOfferAsync);

        group.MapPost("/new-offer", PostNewOfferAsync);

        group.MapPut("/offer", PutOfferAsync);
        return group;
    }

    private static async Task<Results<Ok<OfferDto>, NotFound<ProblemDetails>>>
        GetActualOfferAsync()
    {
        throw new NotImplementedException();
    }

    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest, "application/problem+json")]
    private static async Task<Created<OfferDto>>
        PostNewOfferAsync
        (
            [Description("Данные о создаваемом предложении")]
            OfferRequest request
        )
    {
        throw new NotImplementedException();
    }

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