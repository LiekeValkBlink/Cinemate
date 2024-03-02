using Cinemate.Models.Dto;

namespace Cinemate.Web.Services.Contracts;

public interface IMovieCategoryService
{
    Task<IEnumerable<MovieCategoryDto>> GetAllMovieCategories();
    Task<MovieCategoryDto> GetMovieCategory(int id);
    Task<MovieCategoryDto> AddMovieCategory(AddMovieCategoryDto addMovieCategoryDto);
    Task<MovieCategoryDto> UpdateMovieCategory(MovieCategoryDto movieCategoryDto);
    Task DeleteMovieCategory(int id);
}