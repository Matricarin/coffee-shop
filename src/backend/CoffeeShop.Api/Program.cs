namespace CoffeeShop.Api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddAuthorization();
        
        var app = builder.Build();
        
        app.UseHttpsRedirection();

        app.UseAuthorization();
        
        app.MapGet("/", (HttpContext httpContext) =>
        {

            return "Hello!";
        });

        app.Run();
    }
}
