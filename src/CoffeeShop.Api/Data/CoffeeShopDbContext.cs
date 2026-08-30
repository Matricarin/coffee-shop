using CoffeeShop.Api.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.Api.Data;

public sealed class CoffeeShopDbContext : IdentityDbContext
{
    //  TODO implement DbContext

    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<Product> Products { get; set; }
}