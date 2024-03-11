using Cinemate.API.Entities;
using Cinemate.Models.Static;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinemate.API.Data.Seed;

public class ScreeningConfiguration: IEntityTypeConfiguration<Screening>
{
    public void Configure(EntityTypeBuilder<Screening> builder)
    {
        var today = DateTime.Now;

        builder.HasData(
            new Screening{ Id = 1, TheaterRoomId = 1, MovieId = 1, MovieStart = today.AddHours(3).SetKindUtc()},
            new Screening{ Id = 2, TheaterRoomId = 2, MovieId = 3, MovieStart = today.AddHours(3).SetKindUtc()},
            new Screening{ Id = 3, TheaterRoomId = 3, MovieId = 2, MovieStart = today.AddHours(3).SetKindUtc()},
            new Screening{ Id = 4, TheaterRoomId = 4, MovieId = 4, MovieStart = today.AddHours(3).SetKindUtc()},
            new Screening{ Id = 5, TheaterRoomId = 5, MovieId = 6, MovieStart = today.AddHours(3).SetKindUtc()},
            new Screening{ Id = 6, TheaterRoomId = 6, MovieId = 5, MovieStart = today.AddHours(3).SetKindUtc()},
            new Screening{ Id = 7, TheaterRoomId = 1, MovieId = 9, MovieStart = today.AddHours(6).SetKindUtc()},
            new Screening{ Id = 8, TheaterRoomId = 2, MovieId = 6, MovieStart = today.AddHours(6).SetKindUtc()},
            new Screening{ Id = 9, TheaterRoomId = 3, MovieId = 8, MovieStart = today.AddHours(6).SetKindUtc()},
            new Screening{ Id = 10, TheaterRoomId = 4, MovieId = 6, MovieStart = today.AddHours(6).SetKindUtc()},
            new Screening{ Id = 11, TheaterRoomId = 5, MovieId = 1, MovieStart = today.AddHours(6).SetKindUtc()},
            new Screening{ Id = 12, TheaterRoomId = 6, MovieId = 3, MovieStart = today.AddHours(6).SetKindUtc()},
            new Screening{ Id = 13, TheaterRoomId = 1, MovieId = 9, MovieStart = today.AddHours(5).SetKindUtc()},
            new Screening{ Id = 14, TheaterRoomId = 2, MovieId = 2, MovieStart = today.AddHours(5).SetKindUtc()},
            new Screening{ Id = 15, TheaterRoomId = 3, MovieId = 3, MovieStart = today.AddHours(5).SetKindUtc()},
            new Screening{ Id = 16, TheaterRoomId = 4, MovieId = 7, MovieStart = today.AddHours(5).SetKindUtc()},
            new Screening{ Id = 17, TheaterRoomId = 5, MovieId = 6, MovieStart = today.AddHours(5).SetKindUtc()},
            new Screening{ Id = 18, TheaterRoomId = 6, MovieId = 4, MovieStart = today.AddHours(3).SetKindUtc()},
            new Screening{ Id = 19, TheaterRoomId = 1, MovieId = 3, MovieStart = today.AddHours(24).SetKindUtc()},
            new Screening{ Id = 20, TheaterRoomId = 2, MovieId = 1, MovieStart = today.AddHours(24).SetKindUtc()},
            new Screening{ Id = 21, TheaterRoomId = 3, MovieId = 2, MovieStart = today.AddHours(24).SetKindUtc()},
            new Screening{ Id = 22, TheaterRoomId = 4, MovieId = 4, MovieStart = today.AddHours(24).SetKindUtc()},
            new Screening{ Id = 23, TheaterRoomId = 5, MovieId = 6, MovieStart = today.AddHours(24).SetKindUtc()},
            new Screening{ Id = 24, TheaterRoomId = 6, MovieId = 5, MovieStart = today.AddHours(24).SetKindUtc()},
            new Screening{ Id = 25, TheaterRoomId = 1, MovieId = 2, MovieStart = today.AddHours(24).SetKindUtc()},
            new Screening{ Id = 26, TheaterRoomId = 2, MovieId = 6, MovieStart = today.AddHours(24).SetKindUtc()},
            new Screening{ Id = 27, TheaterRoomId = 3, MovieId = 8, MovieStart = today.AddHours(24).SetKindUtc()},
            new Screening{ Id = 28, TheaterRoomId = 4, MovieId = 6, MovieStart = today.AddHours(24).SetKindUtc()},
            new Screening{ Id = 29, TheaterRoomId = 5, MovieId = 1, MovieStart = today.AddHours(24).SetKindUtc()},
            new Screening{ Id = 30, TheaterRoomId = 6, MovieId = 3, MovieStart = today.AddHours(24).SetKindUtc()},
            new Screening{ Id = 31, TheaterRoomId = 1, MovieId = 1, MovieStart = today.AddHours(24).SetKindUtc()},
            new Screening{ Id = 32, TheaterRoomId = 2, MovieId = 2, MovieStart = today.AddHours(24).SetKindUtc()},
            new Screening{ Id = 33, TheaterRoomId = 3, MovieId = 3, MovieStart = today.AddHours(24).SetKindUtc()},
            new Screening{ Id = 34, TheaterRoomId = 4, MovieId = 7, MovieStart = today.AddHours(24).SetKindUtc()},
            new Screening{ Id = 35, TheaterRoomId = 5, MovieId = 6, MovieStart = today.AddHours(24).SetKindUtc()},
            new Screening{ Id = 36, TheaterRoomId = 6, MovieId = 4, MovieStart = today.AddHours(24).SetKindUtc()}
        
        );
        
    }
}