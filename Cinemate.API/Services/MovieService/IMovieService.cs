using Cinemate.Models.Dto;
using Microsoft.AspNetCore.Components.Forms;

namespace Cinemate.API.Services.MovieService;

public interface IMovieService
{
    Task<IEnumerable<MovieWithCategoryDto>> GetAllMovies();
    Task<MovieWithCategoryDto?> GetSingleMovie(int id);
    Task<MovieWithCategoryDto> AddMovie(MovieDto movie);
    Task<MovieDto?> UpdateMovie(MovieDto movie, int id);
    Task DeleteMovie(int id);

}