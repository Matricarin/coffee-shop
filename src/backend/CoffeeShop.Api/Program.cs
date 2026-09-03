using CoffeeShop.Api.Extensions;

namespace CoffeeShop.Api;

public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddCoffeeShopContext(builder.Configuration);
        builder.Services.AddIdentityContext();

        builder.Services.AddAuthorization();
        
        var app = builder.Build();
        
        app.UseHttpsRedirection();

        app.UseAuthorization();
        
        app.MapGet("/", (HttpContext _) => "Hello!");

        app.Run();
    }
}
