using CoffeeShop.Api.Models;
using CoffeeShop.Api.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.Api.Infrastructure;

public sealed class CoffeeShopContext : DbContext   
{
    public DbSet<Purchase> Purchases { get; set; }

    public DbSet<Card> Cards { get; set; }

    public DbSet<CardCover> CardCovers { get; set; }

    public DbSet<Offer> Offers { get; set; }
}