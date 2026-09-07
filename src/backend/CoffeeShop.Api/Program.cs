using CoffeeShop.Api.Apis;
using Scalar.AspNetCore;

namespace CoffeeShop.Api;

public static class Program
{
    public static void Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

        builder.Services.AddAuthorization();

        builder.Services.AddOpenApi();

        WebApplication app = builder.Build();

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapCoffeeShopApi();

        app.MapOpenApi();

        app.MapScalarApiReference();

        app.Run();
    }
}