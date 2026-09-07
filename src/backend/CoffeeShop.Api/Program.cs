using CoffeeShop.Api.Apis;
using CoffeeShop.Api.Extensions;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;

namespace CoffeeShop.Api;

public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddAuthorization();
        
        var app = builder.Build();
        
        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapCoffeeShopApi();

        app.Run();
    }
}
