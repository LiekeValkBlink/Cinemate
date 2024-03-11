using Cinemate.API.Entities;
using Cinemate.Models.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinemate.API.Data.Seed;

public class PromoCodeConfiguration: IEntityTypeConfiguration<PromoCode>
{
    public void Configure(EntityTypeBuilder<PromoCode> builder)
    {
        builder.HasData(
            new PromoCode
            {
                Id = 1, Active = true, UsesLeft = 999999, DiscountType = DiscountTypes.DecimalDecrease.ToString(),
                Discount = "2.5", Name = "Geheime film"
            },
            new PromoCode
            {
                Id = 2, Active = true, UsesLeft = 999999, DiscountType = DiscountTypes.DecimalIncrease.ToString(),
                Discount = "2.5", Name = "Popcorn arrangement"
            });
    }
}