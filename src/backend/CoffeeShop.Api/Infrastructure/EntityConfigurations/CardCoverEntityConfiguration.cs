using CoffeeShop.Api.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeShop.Api.Infrastructure.EntityConfigurations;

public class CardCoverEntityConfiguration : IEntityTypeConfiguration<CardCover>
{
    public void Configure(EntityTypeBuilder<CardCover> builder)
    {
        throw new NotImplementedException();
    }
}