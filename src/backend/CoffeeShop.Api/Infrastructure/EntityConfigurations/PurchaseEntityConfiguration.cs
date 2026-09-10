using CoffeeShop.Api.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeShop.Api.Infrastructure.EntityConfigurations;

public sealed class PurchaseEntityConfiguration : IEntityTypeConfiguration<Purchase>
{
    public void Configure(EntityTypeBuilder<Purchase> builder)
    {
        throw new NotImplementedException();
    }
}