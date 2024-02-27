using Cinemate.Models.Dto;

namespace Cinemate.API.Services.CategoryService;

public interface IMovieCategoryService
{
    Task<IEnumerable<MovieCategoryDto>> GetAllMovieCategories();
    Task<MovieCategoryDto> GetMovieCategory(int id);
    Task<MovieCategoryDto> AddMovieCategory(MovieCategoryDto movieCategoryDto);
    Task<MovieCategoryDto> UpdateMovieCategory(MovieCategoryDto movieCategoryDto);
    Task DeleteMovieCategory(int id);
}

