using CoffeeShop.Api.Endpoints;
using CoffeeShop.Api.Extensions;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;

namespace CoffeeShop.Api;

public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        //builder.Services.AddCoffeeShopContext(builder.Configuration);

        //builder.Services.AddIdentityContext();

        //  TODO: Зачем нужен? На каком этапе?
        builder.Services.AddHealthChecks();

        builder.Services.AddAuthorization();
        
        var app = builder.Build();

        //  TODO: Зачем он нужен и на каком этапе?

        app.MapHealthChecks("/health", new HealthCheckOptions()
        {
            ResponseWriter = async (context, health) =>
            {
                await context.Response.WriteAsync("healthy!");
            }
        });
        
        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapCoffeeShopEndpoints();

        app.Run();
    }
}
