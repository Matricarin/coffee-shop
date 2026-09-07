    using CoffeeShop.Api.Infrastructure.EntityConfigurations;
    using CoffeeShop.Api.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.Api.Infrastructure;

public sealed class CoffeeShopContext : DbContext   
{
    public DbSet<CardCover> CardCovers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CardCoverEntityConfiguration());
    }
}