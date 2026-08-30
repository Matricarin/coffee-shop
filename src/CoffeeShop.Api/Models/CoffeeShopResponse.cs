using System.Net;

namespace CoffeeShop.Api.Models;

public sealed record CoffeeShopResponse
{
    public object? Result { get; init; }
    public bool IsSuccess { get; init; } = true;
    public HttpStatusCode HttpStatusCode { get; init; }
    public List<string> ErrorMessages { get; init; } = [];
}