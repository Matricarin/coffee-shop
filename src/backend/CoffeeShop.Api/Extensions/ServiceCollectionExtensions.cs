using CoffeeShop.Api.Infrastructure;
using CoffeeShop.Api.Models.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.Api.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCoffeeShopContext(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<CoffeeShopContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("PostgresConnection"));
        });

        return services;
    }

    public static IServiceCollection AddIdentityContext(this IServiceCollection services)
    {
        services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 8;

                options.User.RequireUniqueEmail = false;
            })
            .AddEntityFrameworkStores<CoffeeShopContext>()
            .AddUserManager<UserManager<ApplicationUser>>();

        //  TODO: почему нельзя зарегистрировать отдельных менеджеров для пользователей.
        //services.AddScoped<UserManager<Administrator>>();
        //services.AddScoped<UserManager<Client>>();

        return services;
    }
}