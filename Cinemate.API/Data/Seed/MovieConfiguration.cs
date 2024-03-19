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
                Description = "Het verhaal van hoe een jonge Willy Wonka zijn legendarische Oempa-Loempa-medewerkers voor het eerst ontmoet, hoe hij de beroemdste chocoladefabriek ter wereld in handen kreeg en hoe de Oempa-Loempa's hem van de hongerdood redden.",
                Duration = 115,
                ReleaseYear = 2023,
                MovieCategoryId = 1,
                ReleaseCountry = "US",
                Director = "Paul King",
                Cast = "Timothée Chalamet, Keegan-Michael Key, Michael B. Jordan",
                Review = (decimal)7.1,
                Kijkwijzers = "6 jaar, Grof taalgebruik",
                ThreeDimensional = false
            },
            new Movie
            {
                Id = 2,
                Title = "Avatar: The Way of Water",
                Description = "The Way of Water: Een vervolg op Avatar (2009).",
                Duration = 160,
                ReleaseYear = 2022,
                ReleaseCountry = "US",
                MovieCategoryId = 1,
                Director = "James Cameron",
                Cast = "Sam Worthington, Zoe Saldana, Sigourney Weaver",
                Review = (decimal)7.8,
                Kijkwijzers = "Alle leeftijden, 6 jaar,12 jaar,16 jaar,Geweld,Angst,Grof taalgebruik,Discriminatie,Drugs- en/of alcoholgebruik,Seks",
                ThreeDimensional = false
            },
            new Movie
            {
                Id = 3,
                Title = "Frozen II",
                Description = "Anna, Elsa, Kristoff, Olaf en Sven verlaten Arendelle om naar een oud, herfstachtig bos te reizen in een betoverd land. Ze gaan op zoek naar de oorsprong van Elsa's krachten om hun koninkrijk te redden.",
                Duration = 103,
                ReleaseYear = 2019,
                ReleaseCountry = "US",
                MovieCategoryId = 1,
                Director = "Chris Buck, Jennifer Lee",
                Cast = "Kristen Bell, Idina Menzel, Josh Gad",
                Review = (decimal)7.0,
                Kijkwijzers = "6 jaar, Grof taalgebruik",
                ThreeDimensional = false
            },
            new Movie
            {
                Id = 4,
                Title = "The Hunger Games",
                Description = "Katniss Everdeen neemt vrijwillig de plaats in van haar jongere zusje in de Hongerspelen: een getelevisieerde competitie waarin twee tieners uit elk van de twaalf districten van Panem willekeurig worden gekozen om tot de dood te vechten.",
                Duration = 142,
                ReleaseYear = 2012,
                ReleaseCountry = "US",
                MovieCategoryId = 1,
                Director = "Gary Ross",
                Cast = "Jennifer Lawrence, Josh Hutcherson, Liam Hemsworth",
                Review = (decimal)7.2,
                Kijkwijzers = "12 jaar, Geweld, Angst",
                ThreeDimensional = false
            },
            new Movie
            {
                Id = 5,
                Title = "Wish",
                Description = "Een jongen begint aan een queeste om zijn zieke moeder te redden door op zoek te gaan naar een mythische figuur die magische genezende krachten zou hebben.",
                Duration = 110,
                ReleaseYear = 2020,
                ReleaseCountry = "US",
                MovieCategoryId = 1,
                Director = "Dexter Fletcher",
                Cast = "Daniel Radcliffe, Jodie Foster, Chiwetel Ejiofor",
                Review = (decimal)6.8,
                Kijkwijzers = "6 jaar, Grof taalgebruik",
                ThreeDimensional = false
            },
            new Movie
            {
                Id = 6,
                Title = "Anyone But You",
                Description = "Twee rivaliserende muzikanten, Lindsay en Wes, belanden per ongeluk in dezelfde stad. Het grootste probleem is dat de band van Lindsay uit elkaar is gevallen en Wes miljonair is geworden, waardoor ze partners worden en het recht krijgen om zich met elkaars leven te bemoeien.",
                Duration = 96,
                ReleaseYear = 2022,
                ReleaseCountry = "US",
                MovieCategoryId = 1,
                Director = "Josie Day",
                Cast = "Brittany Bristow, Jordan Dean, Taveeta Szymanowicz",
                Review = (decimal)6.5,
                Kijkwijzers = "Alle leeftijden",
                ThreeDimensional = false
            },
            new Movie
            {
                Id = 7,
                Title = "Spider-Man: Across the Spider-Verse",
                Description = "Across the Spider-Verse: Een voortzetting van Spider-Man: Into the Spider-Verse (2018).",
                Duration = 90,
                ReleaseYear = 2022,
                ReleaseCountry = "US",
                MovieCategoryId = 1,
                Director = "Joaquim Dos Santos, Kemp Powers",
                Cast = "Shameik Moore, Hailee Steinfeld, Jake Johnson",
                Review = (decimal)8.0,
                Kijkwijzers = "12 jaar, Geweld",
                ThreeDimensional = false
            },
            new Movie
            {
                Id = 8,
                Title = "Oppenheimer",
                Description = "Het verhaal van de ontwikkeling van de atoombom door het Manhattan Project tijdens de Tweede Wereldoorlog, en de complexe interpersoonlijke relaties van de briljante maar gebrekkige mannen die het ontwikkelden.",
                Duration = 120,
                ReleaseYear = 2023,
                ReleaseCountry = "US",
                MovieCategoryId = 1,
                Director = "Christopher Nolan",
                Cast = "Cillian Murphy, Robert Downey Jr., Emily Blunt",
                Review = (decimal)8.5,
                Kijkwijzers = "12 jaar, Geweld",
                ThreeDimensional = false
            },
            new Movie
            {
                Id = 10,
                Title = "Oppenheimer (3D)",
                Description = "Het verhaal van de ontwikkeling van de atoombom door het Manhattan Project tijdens de Tweede Wereldoorlog, en de complexe interpersoonlijke relaties van de briljante maar gebrekkige mannen die het ontwikkelden.",
                Duration = 120,
                ReleaseYear = 2023,
                ReleaseCountry = "US",
                MovieCategoryId = 1,
                Director = "Christopher Nolan",
                Cast = "Cillian Murphy, Robert Downey Jr., Emily Blunt",
                Review = (decimal)8.5,
                Kijkwijzers = "12 jaar, Geweld",
                ThreeDimensional = false
            },
            new Movie
            {
                Id = 9,
                Title = "Barbie",
                Description = "Barbie en Ken hebben de tijd van hun leven in de kleurrijke en ogenschijnlijk perfecte wereld van Barbie Land. Echter, wanneer ze een kans krijgen om naar de echte wereld te gaan, ontdekken ze al snel de vreugden en gevaren van het leven onder de mensen",
                Duration = 116,
                ReleaseYear = 2023,
                ReleaseCountry = "US",
                MovieCategoryId = 2,
                Director = "Greta Gerwig",
                Cast = "Margot Robbie",
                Review = (decimal)7.5,
                Kijkwijzers = "Alle leeftijden",
                ThreeDimensional = false
            }
        );
        
    }
}
