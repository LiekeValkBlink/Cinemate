using Cinemate.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinemate.API.Data.Seed;

public class ReservationConfiguration: IEntityTypeConfiguration<Reservation>
{
    public void Configure(EntityTypeBuilder<Reservation> builder)
    {
        // Generate around 50 reservations
        var random = new Random();
        
        builder.HasData(new Reservation { Id = 1, EmployeeId = 1, ScreeningId = 1, Paid = true, PaymentType = "iDeal", UserId = 1, Price = 10});
        
        for (int i = 2; i <= 50; i++)
        {
            // Generate random values for demonstration purposes
            var reservation = new Reservation
            {
                Id = i,
                UserId = random.Next(1, 6), // Assuming there are 5 users in the database
                ScreeningId = random.Next(1, 37), // Assuming there are 36 screenings in the database
                Paid = random.Next(0, 2) == 1, // Randomly assign true or false for Paid
                EmployeeId = random.Next(1, 6), // Assuming there are 5 employees in the database
                Price = (decimal)(random.NextDouble() * 100), // Random price between 0 and 100
                PaymentType = random.Next(0, 2) == 1 ? "Credit Card" : "Cash" // Randomly assign payment type
            };

            builder.HasData(reservation);
        }
    }
}