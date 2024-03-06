using Cinemate.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinemate.API.Data.Seed;

public class SeatsConfiguration: IEntityTypeConfiguration<Seat>
{
    public void Configure(EntityTypeBuilder<Seat> builder)
    {
        // Seats for theaters 1 to 3
        int idCounter = 1; // Initialize a counter for generating unique Id values
    
        // Seats for theaters 1 to 3
        for (int theaterId = 1; theaterId <= 3; theaterId++)
        {
            for (int row = 1; row <= 8; row++)
            {
                for (int seatNumber = 1; seatNumber <= 15; seatNumber++)
                {
                    builder.HasData(new Seat
                    {
                        Id = idCounter++,
                        Row = row,
                        Number = seatNumber,
                        TheaterRoomId = theaterId
                    });
                }
            }
        }
    
        // Seats for theater 4
        for (int row = 1; row <= 6; row++)
        {
            for (int seatNumber = 1; seatNumber <= 10; seatNumber++)
            {
                builder.HasData(new Seat
                {
                    Id = idCounter++,
                    Row = row,
                    Number = seatNumber,
                    TheaterRoomId = 4
                });
            }
        }
    
        // Seats for theaters 5 and 6
        for (int theaterId = 5; theaterId <= 6; theaterId++)
        {
            // Front rows with 2 rows of 10 seats
            for (int row = 1; row <= 2; row++)
            {
                for (int seatNumber = 1; seatNumber <= 10; seatNumber++)
                {
                    builder.HasData(new Seat
                    {
                        Id = idCounter++,
                        Row = row,
                        Number = seatNumber,
                        TheaterRoomId = theaterId
                    });
                }
            }
    
            // Back rows with 2 rows of 15 seats
            for (int row = 3; row <= 4; row++)
            {
                for (int seatNumber = 1; seatNumber <= 15; seatNumber++)
                {
                    builder.HasData(new Seat
                    {
                        Id = idCounter++,
                        Row = row,
                        Number = seatNumber,
                        TheaterRoomId = theaterId
                    });
                }
            }
        }
        
    }
}