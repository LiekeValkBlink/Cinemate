using Cinemate.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinemate.API.Data.Seed;

public class TheaterRoomConfiguration: IEntityTypeConfiguration<TheaterRoom>
{
    public void Configure(EntityTypeBuilder<TheaterRoom> builder)
    {
        builder.HasData(
            new TheaterRoom(){ Id = 1, TheaterId = 1, Name = "Zaal 1"},
            new TheaterRoom(){ Id = 2, TheaterId = 1, Name = "Zaal 2"},
            new TheaterRoom(){ Id = 3, TheaterId = 1, Name = "Zaal 3"},
            new TheaterRoom(){ Id = 4, TheaterId = 1, Name = "Zaal 4"},
            new TheaterRoom(){ Id = 5, TheaterId = 1, Name = "Zaal 5"},
            new TheaterRoom(){ Id = 6, TheaterId = 1, Name = "Zaal 6"}
        );
    }
}