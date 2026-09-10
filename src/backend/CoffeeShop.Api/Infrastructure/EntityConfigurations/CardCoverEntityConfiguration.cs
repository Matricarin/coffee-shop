using CoffeeShop.Api.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeShop.Api.Infrastructure.EntityConfigurations;

public sealed class CardCoverEntityConfiguration : IEntityTypeConfiguration<CardCover>
{
    public void Configure(EntityTypeBuilder<CardCover> builder)
    {
        throw new NotImplementedException();
    }
}