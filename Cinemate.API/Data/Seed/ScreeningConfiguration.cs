using Cinemate.API.Entities;
using Cinemate.Models.Static;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinemate.API.Data.Seed;

public class ScreeningConfiguration: IEntityTypeConfiguration<Screening>
{
    public void Configure(EntityTypeBuilder<Screening> builder)
    {
        var today = DateTime.UtcNow.Date;
        var todayAtEight = today.AddHours(20).SetKindUtc();
        var todayAtNine = today.AddHours(21).SetKindUtc();
        var todayAtTen = today.AddHours(22).SetKindUtc();

        var tomorrow = today.AddDays(1);
        var tomorrowAtEight = tomorrow.AddHours(20).SetKindUtc();
        var tomorrowAtNine = tomorrow.AddHours(21).SetKindUtc();
        var tomorrowAtTen = tomorrow.AddHours(22).SetKindUtc();

        var dayAfterTomorrow = today.AddDays(2);
        var dayAfterTomorrowAtEight = dayAfterTomorrow.AddHours(20).SetKindUtc();
        var dayAfterTomorrowAtNine = dayAfterTomorrow.AddHours(21).SetKindUtc();
        var dayAfterTomorrowAtTen = dayAfterTomorrow.AddHours(22).SetKindUtc();

        var day3 = today.AddDays(3);
        var day3AtEight = day3.AddHours(20).SetKindUtc();
        var day3AtNine = day3.AddHours(21).SetKindUtc();
        var day3AtTen = day3.AddHours(22).SetKindUtc();

        var day4 = today.AddDays(4);
        var day4AtEight = day4.AddHours(20).SetKindUtc();
        var day4AtNine = day4.AddHours(21).SetKindUtc();
        var day4AtTen = day4.AddHours(22).SetKindUtc();

        var day5 = today.AddDays(5);
        var day5AtEight = day5.AddHours(20).SetKindUtc();
        var day5AtNine = day5.AddHours(21).SetKindUtc();
        var day5AtTen = day5.AddHours(22).SetKindUtc();

        var day6 = today.AddDays(6);
        var day6AtEight = day6.AddHours(20).SetKindUtc();
        var day6AtNine = day6.AddHours(21).SetKindUtc();
        var day6AtTen = day6.AddHours(22).SetKindUtc();

        builder.HasData(
            new Screening { Id = 1, TheaterRoomId = 1, MovieId = 1, MovieStart = todayAtEight },
            new Screening { Id = 2, TheaterRoomId = 2, MovieId = 2, MovieStart = todayAtEight },
            new Screening { Id = 3, TheaterRoomId = 3, MovieId = 3, MovieStart = todayAtEight },

            new Screening { Id = 4, TheaterRoomId = 1, MovieId = 6, MovieStart = todayAtNine },
            new Screening { Id = 5, TheaterRoomId = 2, MovieId = 7, MovieStart = todayAtNine },
            new Screening { Id = 6, TheaterRoomId = 3, MovieId = 8, MovieStart = todayAtNine },

            new Screening { Id = 7, TheaterRoomId = 1, MovieId = 1, MovieStart = todayAtTen },
            new Screening { Id = 8, TheaterRoomId = 4, MovieId = 4, MovieStart = todayAtTen },

            new Screening { Id = 9, TheaterRoomId = 1, MovieId = 6, MovieStart = tomorrowAtEight },
            new Screening { Id = 10, TheaterRoomId = 3, MovieId = 8, MovieStart = tomorrowAtEight },
            new Screening { Id = 11, TheaterRoomId = 4, MovieId = 9, MovieStart = tomorrowAtEight },
            new Screening { Id = 12, TheaterRoomId = 5, MovieId = 10, MovieStart = tomorrowAtEight },
            
            new Screening { Id = 13, TheaterRoomId = 1, MovieId = 1, MovieStart = tomorrowAtNine },
            new Screening { Id = 14, TheaterRoomId = 3, MovieId = 3, MovieStart = tomorrowAtNine },
            new Screening { Id = 15, TheaterRoomId = 4, MovieId = 4, MovieStart = tomorrowAtNine },

            new Screening { Id = 16, TheaterRoomId = 1, MovieId = 6, MovieStart = tomorrowAtTen },
            new Screening { Id = 17, TheaterRoomId = 3, MovieId = 8, MovieStart = tomorrowAtTen },
            new Screening { Id = 18, TheaterRoomId = 4, MovieId = 9, MovieStart = tomorrowAtTen },
            
            new Screening { Id = 19, TheaterRoomId = 1, MovieId = 1, MovieStart = dayAfterTomorrowAtEight },
            new Screening { Id = 20, TheaterRoomId = 4, MovieId = 4, MovieStart = dayAfterTomorrowAtEight },
            new Screening { Id = 21, TheaterRoomId = 5, MovieId = 5, MovieStart = dayAfterTomorrowAtEight },

            new Screening { Id = 22, TheaterRoomId = 1, MovieId = 6, MovieStart = dayAfterTomorrowAtNine },
            new Screening { Id = 23, TheaterRoomId = 4, MovieId = 9, MovieStart = dayAfterTomorrowAtNine },
            new Screening { Id = 24, TheaterRoomId = 5, MovieId = 10, MovieStart = dayAfterTomorrowAtNine },

            new Screening { Id = 25, TheaterRoomId = 1, MovieId = 1, MovieStart = dayAfterTomorrowAtTen },
            new Screening { Id = 26, TheaterRoomId = 4, MovieId = 4, MovieStart = dayAfterTomorrowAtTen },
            new Screening { Id = 27, TheaterRoomId = 5, MovieId = 5, MovieStart = dayAfterTomorrowAtTen },
            
            new Screening { Id = 28, TheaterRoomId = 3, MovieId = 3, MovieStart = day3AtEight },
            new Screening { Id = 29, TheaterRoomId = 4, MovieId = 4, MovieStart = day3AtEight },
            new Screening { Id = 30, TheaterRoomId = 5, MovieId = 5, MovieStart = day3AtEight },

            new Screening { Id = 31, TheaterRoomId = 1, MovieId = 6, MovieStart = day3AtNine },
            new Screening { Id = 32, TheaterRoomId = 3, MovieId = 8, MovieStart = day3AtNine },
            new Screening { Id = 33, TheaterRoomId = 5, MovieId = 10, MovieStart = day3AtNine },

            new Screening { Id = 34, TheaterRoomId = 3, MovieId = 3, MovieStart = day3AtTen },
            new Screening { Id = 35, TheaterRoomId = 4, MovieId = 4, MovieStart = day3AtTen },
            new Screening { Id = 36, TheaterRoomId = 5, MovieId = 5, MovieStart = day3AtTen },
            
            new Screening { Id = 37, TheaterRoomId = 2, MovieId = 7, MovieStart = day4AtEight },
            new Screening { Id = 38, TheaterRoomId = 4, MovieId = 9, MovieStart = day4AtEight },
            new Screening { Id = 39, TheaterRoomId = 5, MovieId = 10, MovieStart = day4AtEight },

            new Screening { Id = 40, TheaterRoomId = 2, MovieId = 2, MovieStart = day4AtNine },
            new Screening { Id = 41, TheaterRoomId = 3, MovieId = 3, MovieStart = day4AtNine },
            new Screening { Id = 42, TheaterRoomId = 4, MovieId = 4, MovieStart = day4AtNine },

            new Screening { Id = 43, TheaterRoomId = 2, MovieId = 7, MovieStart = day4AtTen },
            new Screening { Id = 44, TheaterRoomId = 4, MovieId = 9, MovieStart = day4AtTen },
            new Screening { Id = 45, TheaterRoomId = 5, MovieId = 10, MovieStart = day4AtTen },
            
            new Screening { Id = 46, TheaterRoomId = 1, MovieId = 1, MovieStart = day5AtEight },
            new Screening { Id = 47, TheaterRoomId = 2, MovieId = 2, MovieStart = day5AtEight },
            new Screening { Id = 48, TheaterRoomId = 4, MovieId = 4, MovieStart = day5AtEight },
            new Screening { Id = 49, TheaterRoomId = 5, MovieId = 5, MovieStart = day5AtEight },

            new Screening { Id = 50, TheaterRoomId = 1, MovieId = 6, MovieStart = day5AtNine },
            new Screening { Id = 51, TheaterRoomId = 2, MovieId = 7, MovieStart = day5AtNine },
            new Screening { Id = 52, TheaterRoomId = 3, MovieId = 8, MovieStart = day5AtNine },
            new Screening { Id = 53, TheaterRoomId = 5, MovieId = 10, MovieStart = day5AtNine },

            new Screening { Id = 54, TheaterRoomId = 1, MovieId = 1, MovieStart = day5AtTen },
            new Screening { Id = 55, TheaterRoomId = 2, MovieId = 2, MovieStart = day5AtTen },
            new Screening { Id = 56, TheaterRoomId = 4, MovieId = 4, MovieStart = day5AtTen },
            new Screening { Id = 57, TheaterRoomId = 5, MovieId = 5, MovieStart = day5AtTen },

            new Screening { Id = 58, TheaterRoomId = 3, MovieId = 8, MovieStart = day6AtEight },
            new Screening { Id = 59, TheaterRoomId = 4, MovieId = 9, MovieStart = day6AtEight },
            new Screening { Id = 60, TheaterRoomId = 5, MovieId = 10, MovieStart = day6AtEight },

            new Screening { Id = 61, TheaterRoomId = 1, MovieId = 1, MovieStart = day6AtNine },
            new Screening { Id = 62, TheaterRoomId = 2, MovieId = 2, MovieStart = day6AtNine },
            new Screening { Id = 63, TheaterRoomId = 4, MovieId = 4, MovieStart = day6AtNine },
            new Screening { Id = 64, TheaterRoomId = 5, MovieId = 5, MovieStart = day6AtNine },

            new Screening { Id = 65, TheaterRoomId = 3, MovieId = 8, MovieStart = day6AtTen },
            new Screening { Id = 66, TheaterRoomId = 4, MovieId = 9, MovieStart = day6AtTen },
            new Screening { Id = 67, TheaterRoomId = 5, MovieId = 10, MovieStart = day6AtTen }
        );
        
    }
}