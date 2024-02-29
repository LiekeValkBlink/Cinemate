using AutoMapper;
using Cinemate.API.Data;
using Cinemate.API.Entities;
using Cinemate.Models.Dto;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;

namespace Cinemate.API.Services.MovieService;

public class MovieService : IMovieService
{
    private readonly CinemateDbContext _dbContext;
    private readonly IMapper _mapper;
    private readonly IWebHostEnvironment _webHostEnvironment;

    public MovieService(CinemateDbContext dbContext, IMapper mapper, IWebHostEnvironment webHostEnvironment)
    {
        //Set the Database and AutoMapper context through DI
        _dbContext = dbContext;
        _mapper = mapper;
        _webHostEnvironment = webHostEnvironment;
    }
    
    public async Task<IEnumerable<MovieWithCategoryDto>> GetAllMovies()
    {
        var movies = await _dbContext.Movies.Join(
            _dbContext.MovieCategories,
            movie => movie.MovieCategoryId,
            category => category.Id,
            (movie, category) => new MovieWithCategoryDto
            {
                Id = movie.Id,
                Title = movie.Title,
                Description = movie.Description,
                Duration = movie.Duration,
                ReleaseYear = movie.ReleaseYear,
                MovieCategoryId = movie.MovieCategoryId,
                Director = movie.Director,
                Cast = movie.Cast,
                Review = movie.Review,
                Kijkwijzers = movie.Kijkwijzers,
                MovieCategoryDescription = category.Name
            }
        ).ToListAsync();
        //Map the return value to a DTO
        return movies;
    }

    public async Task<MovieWithCategoryDto?> GetSingleMovie(int id)
    {
        var movieWithCategory = await _dbContext.Movies
            .Where(m => m.Id == id)
            .Join(
                _dbContext.MovieCategories,
                movie => movie.MovieCategoryId,
                category => category.Id,
                (movie, category) => new MovieWithCategoryDto
                {
                    Id = movie.Id,
                    Title = movie.Title,
                    Description = movie.Description,
                    Duration = movie.Duration,
                    ReleaseYear = movie.ReleaseYear,
                    MovieCategoryId = movie.MovieCategoryId,
                    Director = movie.Director,
                    Cast = movie.Cast,
                    Review = movie.Review,
                    Kijkwijzers = movie.Kijkwijzers,
                    MovieCategoryDescription = category.Name
                })
            .FirstOrDefaultAsync();

        return movieWithCategory;
    }

    public async Task<MovieWithCategoryDto> AddMovie(MovieDto movie)
    {
        //map the DTO to a type that the database can consume
        var movieToAdd = _mapper.Map<Movie>(movie);
        //add it to the database
        _dbContext.Movies.Add(movieToAdd);
        //Wait until changes are saved
        await _dbContext.SaveChangesAsync();
        
        // Retrieve the added movie with its associated category
        var addedMovieWithCategory = await _dbContext.Movies
            .Where(m => m.Id == movieToAdd.Id)
            .Join(
                _dbContext.MovieCategories,
                m => m.MovieCategoryId,
                c => c.Id,
                (m, c) => new MovieWithCategoryDto
                {
                    Id = m.Id,
                    Title = m.Title,
                    Description = m.Description,
                    Duration = m.Duration,
                    ReleaseYear = m.ReleaseYear,
                    MovieCategoryId = m.MovieCategoryId,
                    Director = m.Director,
                    Cast = m.Cast,
                    Review = m.Review,
                    Kijkwijzers = m.Kijkwijzers,
                    MovieCategoryDescription = c.Name
                })
            .FirstOrDefaultAsync();

        return addedMovieWithCategory;
        

    }



    public async Task<MovieDto?> UpdateMovie(MovieDto request, int id)
    {
        var movieToUpdate = await _dbContext.Movies.FindAsync(id);
        if (movieToUpdate == null)
        {
            return null; // movie with the given id was not found
        }

        movieToUpdate.Title = request.Title;
        movieToUpdate.Description = request.Description;
        movieToUpdate.Duration = request.Duration;
        movieToUpdate.ReleaseYear = request.ReleaseYear;
        movieToUpdate.MovieCategoryId = request.MovieCategoryId;
        movieToUpdate.Director = request.Director;
        movieToUpdate.Cast = request.Cast;
        movieToUpdate.Review = request.Review;
        movieToUpdate.Kijkwijzers = request.Kijkwijzers;
        
        await _dbContext.SaveChangesAsync();
        
        return new MovieDto
        {
            Id = movieToUpdate.Id,
            Title = movieToUpdate.Title,
            Description = movieToUpdate.Description,
            Duration = movieToUpdate.Duration,
            ReleaseYear = movieToUpdate.ReleaseYear,
            MovieCategoryId = movieToUpdate.MovieCategoryId,
            Director = movieToUpdate.Director,
            Cast = movieToUpdate.Cast,
            Review = movieToUpdate.Review,
            Kijkwijzers = movieToUpdate.Kijkwijzers
        };

    }

    public async Task DeleteMovie(int id)
    {
        var movieToDelete = await _dbContext.Movies.FindAsync(id);
        if (movieToDelete == null)
        {
            throw new ArgumentException("Movie not found");
        }
        
        var imagePath = Path.Combine(_webHostEnvironment.WebRootPath, "images", $"movie_{id}_image.jpg");
        if (File.Exists(imagePath))
        {
            File.Delete(imagePath);
        }
        
        _dbContext.Movies.Remove(movieToDelete);
        await _dbContext.SaveChangesAsync();
    }
    
}