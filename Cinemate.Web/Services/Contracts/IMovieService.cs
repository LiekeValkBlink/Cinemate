using Cinemate.Models.Dto;
using Microsoft.AspNetCore.Components.Forms;

namespace Cinemate.Web.Services.Contracts;

public interface IMovieService
{
    Task<IEnumerable<MovieWithCategoryDto>> GetMovies();
    Task<MovieWithCategoryDto> GetMovie(int id);
    Task<MovieWithCategoryDto> AddMovie(MovieDto movieDto);
    Task<MovieWithCategoryDto> UpdateMovie(MovieDto movieDto);
    Task DeleteMovie(int id);
    Task UploadMoviePosterImage(IBrowserFile file, int movieId);
    Task UploadMovieScreenShotImage(IBrowserFile file, int movieId);
    

}