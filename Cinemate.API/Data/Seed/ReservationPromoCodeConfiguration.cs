using Cinemate.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinemate.API.Data.Seed;

public class ReservationPromoCodeConfiguration: IEntityTypeConfiguration<ReservationPromoCodes>
{
    public void Configure(EntityTypeBuilder<ReservationPromoCodes> builder)
    {
        builder.HasData(new ReservationPromoCodes{ PromoCodeId = 2, ReservationId = 1});
    }
}