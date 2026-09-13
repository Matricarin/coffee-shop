using CoffeeShop.Api.Models.Dtos.Requests;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace CoffeeShop.Api.Apis;

public static class AuthApi
{
    public static IEndpointRouteBuilder MapAuthGroups(this IEndpointRouteBuilder group)
    {
        group.MapGroup("/api/admin-auth").MapAdminAuthApi();

        group.MapGroup("/api/clients-auth").MapClientsAuthApi();

        return group;
    }

    private static IEndpointRouteBuilder MapAdminAuthApi(this IEndpointRouteBuilder group)
    {
        group.MapPost("/register", RegisterAdminAsync)
            .WithName("RegisterAdmin")
            .WithSummary("Зарегистрировать пользователя с правами администратора")
            .WithDescription("Зарегистрировать пользователя с правами администратора")
            .WithTags("Admin");

        group.MapPost("/login", LoginAdminAsync)
            .WithName("LoginAdmin")
            .WithSummary("Вход пользователя с правами администратора")
            .WithDescription("Вход пользователя с правами администратора")
            .WithTags("Admin");

        group.MapPost("/logout", LogoutAdminAsync)
            .WithName("LogoutAdmin")
            .WithSummary("Выход пользователя с правами администратора")
            .WithDescription("Выход пользователя с правами администратора")
            .WithTags("Admin");

        return group;
    }

    private static async Task<Results<Ok, UnauthorizedHttpResult>> LogoutAdminAsync()
    {
        throw new NotImplementedException();
    }

    private static async Task<Results<Ok, UnauthorizedHttpResult>> LoginAdminAsync()
    {
        throw new NotImplementedException();
    }

    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest, "application/problem+json")]
    private static async Task<Created> RegisterAdminAsync
    (
        HttpContext context,
        [Description("Данные для регистрации администратора")]
        RegisterAdminRequest request
    )
    {
        throw new NotImplementedException();
    }

    private static IEndpointRouteBuilder MapClientsAuthApi(this IEndpointRouteBuilder group)
    {
        group.MapPost("/register", RegisterClientAsync)
            .WithName("RegisterClient")
            .WithSummary("Зарегистрировать пользователя с правами клиента")
            .WithDescription("Зарегистрировать пользователя с правами клиент")
            .WithTags("Client");

        group.MapPost("/login", LoginClientAsync)
            .WithName("LoginClient")
            .WithSummary("Вход пользователя с правами клиента")
            .WithDescription("Вход пользователя с правами клиент")
            .WithTags("Client");

        group.MapPost("/confirm", ConfirmClientAsync)
            .WithName("ConfirmClient")
            .WithSummary("Подтвердить пользователя с правами клиента")
            .WithDescription("Подтвердить пользователя с правами клиент")
            .WithTags("Client");

        group.MapPost("/logout", LogoutClientAsync)
            .WithName("LogoutClient")
            .WithSummary("Выход пользователя с правами клиента")
            .WithDescription("Выход пользователя с правами клиента")
            .WithTags("Client");

        return group;
    }

    private static async Task<Ok> ConfirmClientAsync()
    {
        throw new NotImplementedException();
    }

    private static async Task<Results<Ok, UnauthorizedHttpResult>> LogoutClientAsync()
    {
        throw new NotImplementedException();
    }

    private static async Task<Results<Ok, UnauthorizedHttpResult>> LoginClientAsync()
    {
        throw new NotImplementedException();
    }

    private static async Task<Created> RegisterClientAsync()
    {
        throw new NotImplementedException();
    }
}