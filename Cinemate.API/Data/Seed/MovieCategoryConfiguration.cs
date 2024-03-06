using Cinemate.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinemate.API.Data.Seed;

public class MovieCategoryConfiguration: IEntityTypeConfiguration<MovieCategory>
{
    public void Configure(EntityTypeBuilder<MovieCategory> builder)
    {
        builder.HasData(
            new MovieCategory { Id = 1, Name = "Action"},
            new MovieCategory { Id = 2, Name = "Comedy" },
            new MovieCategory { Id = 3, Name = "Drama" },
            new MovieCategory { Id = 4, Name = "Horror" },
            new MovieCategory { Id = 5, Name = "Science Fiction" },
            new MovieCategory { Id = 6, Name = "Thriller" },
            new MovieCategory { Id = 7, Name = "Romance" },
            new MovieCategory { Id = 8, Name = "Adventure" },
            new MovieCategory { Id = 9, Name = "Fantasy" },
            new MovieCategory { Id = 10, Name = "Animation" }
        );
    }
}