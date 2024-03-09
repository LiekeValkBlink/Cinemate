using Cinemate.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinemate.API.Data.Seed;

public class SeatsReservedConfiguration: IEntityTypeConfiguration<SeatReserved>
{
    public void Configure(EntityTypeBuilder<SeatReserved> builder)
    {
        builder.HasData(
         new SeatReserved { Id = 1, ReservationId = 1, SeatId = 13},  
         new SeatReserved { Id = 2, ReservationId = 1, SeatId = 14},
         new SeatReserved { Id = 3, ReservationId = 1, SeatId = 15}  
        );
    }
}