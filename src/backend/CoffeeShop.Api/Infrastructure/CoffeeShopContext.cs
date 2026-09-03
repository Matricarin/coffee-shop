using CoffeeShop.Api.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.Api.Infrastructure;

public sealed class CoffeeShopContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
{
    public DbSet<AdminUser> AdminUsers => Set<AdminUser>();
    public DbSet<ClientUser> ClientUsers => Set<ClientUser>();

    public CoffeeShopContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<ApplicationUser>()
            .HasDiscriminator<string>("User Type")
            .HasValue<AdminUser>(ApplicationRoles.Admin)
            .HasValue<ClientUser>(ApplicationRoles.Client);

        builder.Entity<AdminUser>(b =>
        {
            b.Property(u => u.Email).IsRequired();
        });

        builder.Entity<ClientUser>(b =>
        {
            b.Property(u => u.PhoneNumber).IsRequired();
        });
    }
}