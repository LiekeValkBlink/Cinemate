using Cinemate.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinemate.API.Data.Seed;

public class MovieConfiguration : IEntityTypeConfiguration<Movie>
{
    public void Configure(EntityTypeBuilder<Movie> builder)
    {
        builder.HasData(
            new Movie
            {
                Id = 1,
                Title = "Wonka",
                Description = "The story of how a young Willy Wonka meets his legendary Oompa-Loompa associates for the first time, how he came to own the world's most famous chocolate factory, and how Oompa-Loompas saved him from starvation.",
                Duration = 115,
                ReleaseYear = 2023,
                MovieCategoryId = 1,
                Director = "Paul King",
                Cast = "Timothée Chalamet, Keegan-Michael Key, Michael B. Jordan",
                Review = (decimal)7.1,
                Kijkwijzers = "6, Grof taalgebruik"
            },
            new Movie
            {
                Id = 2,
                Title = "Avatar: The Way of Water",
                Description = "A sequel to Avatar (2009).",
                Duration = 160,
                ReleaseYear = 2022,
                MovieCategoryId = 1,
                Director = "James Cameron",
                Cast = "Sam Worthington, Zoe Saldana, Sigourney Weaver",
                Review = (decimal)7.8,
                Kijkwijzers = "12, Geweld, Angst"
            },
            new Movie
            {
                Id = 3,
                Title = "Frozen II",
                Description = "Anna, Elsa, Kristoff, Olaf and Sven leave Arendelle to travel to an ancient, autumn-bound forest of an enchanted land. They set out to find the origin of Elsa's powers in order to save their kingdom.",
                Duration = 103,
                ReleaseYear = 2019,
                MovieCategoryId = 1,
                Director = "Chris Buck, Jennifer Lee",
                Cast = "Kristen Bell, Idina Menzel, Josh Gad",
                Review = (decimal)7.0,
                Kijkwijzers = "6, Grof taalgebruik"
            },
            new Movie
            {
                Id = 4,
                Title = "The Hunger Games",
                Description = "Katniss Everdeen voluntarily takes her younger sister's place in the Hunger Games: a televised competition in which two teenagers from each of the twelve Districts of Panem are chosen at random to fight to the death.",
                Duration = 142,
                ReleaseYear = 2012,
                MovieCategoryId = 1,
                Director = "Gary Ross",
                Cast = "Jennifer Lawrence, Josh Hutcherson, Liam Hemsworth",
                Review = (decimal)7.2,
                Kijkwijzers = "12, Geweld, Angst"
            },
            new Movie
            {
                Id = 5,
                Title = "Wish",
                Description = "A boy sets out on a quest to save his ill mother by searching for a mythic figure said to have magical healing powers.",
                Duration = 110,
                ReleaseYear = 2020,
                MovieCategoryId = 1,
                Director = "Dexter Fletcher",
                Cast = "Daniel Radcliffe, Jodie Foster, Chiwetel Ejiofor",
                Review = (decimal)6.8,
                Kijkwijzers = "6, Grof taalgebruik"
            },
            new Movie
            {
                Id = 6,
                Title = "Anyone But You",
                Description = "Two rival musicians, Lindsay and Wes, accidentally end up in the same town. The main problem is that Lindsay's band has broken up and Wes has become a millionaire, which makes them partners and gives them the right to interfere in each other's lives.",
                Duration = 96,
                ReleaseYear = 2022,
                MovieCategoryId = 1,
                Director = "Josie Day",
                Cast = "Brittany Bristow, Jordan Dean, Taveeta Szymanowicz",
                Review = (decimal)6.5,
                Kijkwijzers = "Alle leeftijden"
            },
            new Movie
            {
                Id = 7,
                Title = "Spider-Man: Across the Spider-Verse",
                Description = "A continuation of Spider-Man: Into the Spider-Verse (2018).",
                Duration = 90,
                ReleaseYear = 2022,
                MovieCategoryId = 1,
                Director = "Joaquim Dos Santos, Kemp Powers",
                Cast = "Shameik Moore, Hailee Steinfeld, Jake Johnson",
                Review = (decimal)8.0,
                Kijkwijzers = "12, Geweld"
            },
            new Movie
            {
                Id = 8,
                Title = "Oppenheimer",
                Description = "The story of the development of the atomic bomb by the Manhattan Project during World War II, and the complex interpersonal relationships of the brilliant but flawed men who developed it.",
                Duration = 120,
                ReleaseYear = 2023,
                MovieCategoryId = 1,
                Director = "Christopher Nolan",
                Cast = "Cillian Murphy, Robert Downey Jr., Emily Blunt",
                Review = (decimal)8.5,
                Kijkwijzers = "12, Geweld"
            },
            new Movie
            {
                Id = 9,
                Title = "Barbie",
                Description = "Barbie and Ken are having the time of their lives in the colorful and seemingly perfect world of Barbie Land. However, when they get a chance to go to the real world, they soon discover the joys and perils of living among humans.",
                Duration = 116,
                ReleaseYear = 2023,
                MovieCategoryId = 2,
                Director = "Greta Gerwig",
                Cast = "Margot Robbie",
                Review = (decimal)7.5,
                Kijkwijzers = "AL"
            }
        );
        
    }
}
