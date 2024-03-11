using Cinemate.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinemate.API.Data.Seed;

public class TheaterConfiguration: IEntityTypeConfiguration<Theater>
{
    public void Configure(EntityTypeBuilder<Theater> builder)
    {
        builder.HasData(new Theater{ City = "Breda", Country = "NL", HouseNr = "1", Id = 1, Name = "Cinemate", Street = "Hogeschoollaan"});
    }
}