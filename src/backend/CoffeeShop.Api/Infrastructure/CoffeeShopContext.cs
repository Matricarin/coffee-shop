using CoffeeShop.Api.Models.Users;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.Api.Infrastructure;

public sealed class CoffeeShopContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
{
    public DbSet<Administrator> AdminUsers => Set<Administrator>();
    public DbSet<Client> ClientUsers => Set<Client>();

    public CoffeeShopContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<ApplicationUser>()
            .HasDiscriminator<string>("User Type")
            .HasValue<Administrator>(ApplicationRoles.Administrator)
            .HasValue<Client>(ApplicationRoles.Client);

        builder.Entity<Administrator>(b =>
        {
            b.Property(u => u.Email).IsRequired();
        });

        builder.Entity<Client>(b =>
        {
            b.Property(u => u.PhoneNumber).IsRequired();
        });
    }
}