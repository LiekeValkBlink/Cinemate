using Cinemate.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinemate.API.Data.Seed;

public class MovieConfiguration : IEntityTypeConfiguration<Movie>
{
    public void Configure(EntityTypeBuilder<Movie> builder)
    {
        builder.HasData(
            new Movie() { Id = 1,
                Title = "Star Wars: Episode I - The Phantom Menace",
                Description = "Two Jedi Knights escape a hostile blockade to find allies and come across a young boy who may bring balance to the Force, but the long dormant Sith resurface to claim their original glory.",
                Duration = 136,
                ReleaseYear = 1999,
                MovieCategoryId = 1,
                Director = "George Lucas",
                Cast = "Liam Neeson, Ewan McGregor, Natalie Portman",
                Review = (decimal)7.4,
                Kijkwijzers = "12, Geweld"},
            new Movie
            {
                Id = 2,
                Title = "Star Wars: Episode II - Attack of the Clones",
                Description = "Ten years after initially meeting, Anakin Skywalker shares a forbidden romance with Padmé Amidala, while Obi-Wan Kenobi investigates an assassination attempt on the senator and discovers a secret clone army crafted for the Jedi.",
                Duration = 142,
                ReleaseYear = 2002,
                MovieCategoryId = 1,
                Director = "George Lucas",
                Cast = "Hayden Christensen, Natalie Portman, Ewan McGregor",
                Review = (decimal)6.5,
                Kijkwijzers = "12, Geweld"
            },
            new Movie
            {
                Id = 3,
                Title = "Star Wars: Episode III - Revenge of the Sith",
                Description = "Three years into the Clone Wars, the Jedi rescue Palpatine from Count Dooku. As Obi-Wan pursues a new threat, Anakin acts as a double agent between the Jedi Council and Palpatine and is lured into a sinister plan to rule the galaxy.",
                Duration = 140,
                ReleaseYear = 2005,
                MovieCategoryId = 1,
                Director = "George Lucas",
                Cast = "Hayden Christensen, Natalie Portman, Ewan McGregor",
                Review = (decimal)7.5,
                Kijkwijzers = "12, Geweld"
            },
            new Movie
            {
                Id = 4,
                Title = "The Shawshank Redemption",
                Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                Duration = 142,
                ReleaseYear = 1994,
                MovieCategoryId = 3,
                Director = "Frank Darabont",
                Cast = "Tim Robbins, Morgan Freeman, Bob Gunton",
                Review = (decimal)9.3,
                Kijkwijzers = "Geweld, Discriminatie"
            },
            new Movie
            {
                Id = 5,
                Title = "The Godfather",
                Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",
                Duration = 175,
                ReleaseYear = 1972,
                MovieCategoryId = 3,
                Director = "Francis Ford Coppola",
                Cast = "Marlon Brando, Al Pacino, James Caan",
                Review = (decimal)9.2,
                Kijkwijzers = "16, Geweld"
            },
            new Movie
            {
                Id = 6,
                Title = "The Dark Knight",
                Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                Duration = 152,
                ReleaseYear = 2008,
                MovieCategoryId = 6,
                Director = "Christopher Nolan",
                Cast = "Christian Bale, Heath Ledger, Aaron Eckhart",
                Review = (decimal)9.0,
                Kijkwijzers = "16, Geweld, Angst"
            },
            new Movie
            {
                Id = 7,
                Title = "The Lord of the Rings: The Return of the King",
                Description = "Gandalf and Aragorn lead the World of Men against Saurons army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.",
                Duration = 201,
                ReleaseYear = 2003,
                MovieCategoryId = 8,
                Director = "Peter Jackson",
                Cast = "Elijah Wood, Viggo Mortensen, Ian McKellen",
                Review = (decimal)8.9,
                Kijkwijzers = "16, Geweld, Angst"
            },
            new Movie
            {
                Id = 8,
                Title = "Inception",
                Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.",
                Duration = 148,
                ReleaseYear = 2010,
                MovieCategoryId = 5,
                Director = "Christopher Nolan",
                Cast = "Leonardo DiCaprio, Joseph Gordon-Levitt, Ellen Page",
                Review = (decimal)8.8,
                Kijkwijzers = "12, Geweld, Angst"
            },
            new Movie
            {
                Id = 9,
                Title = "Pulp Fiction",
                Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                Duration = 154,
                ReleaseYear = 1994,
                MovieCategoryId = 6,
                Director = "Quentin Tarantino",
                Cast = "John Travolta, Uma Thurman, Samuel L. Jackson",
                Review = (decimal)8.9,
                Kijkwijzers = "16, Geweld, Angst"
            },
            new Movie
            {
                Id = 10,
                Title = "Forrest Gump",
                Description = "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.",
                Duration = 142,
                ReleaseYear = 1994,
                MovieCategoryId = 7,
                Director = "Robert Zemeckis",
                Cast = "Tom Hanks, Robin Wright, Gary Sinise",
                Review = (decimal)8.8,
                Kijkwijzers = "12, Geweld, Angst"
            }
        );
        
    }
}
