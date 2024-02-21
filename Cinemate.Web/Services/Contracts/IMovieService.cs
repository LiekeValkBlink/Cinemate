using Cinemate.Models.Dto;

namespace Cinemate.Web.Services.Contracts;

public interface IMovieService
{
    Task<IEnumerable<MovieWithCategoryDto>> GetMovies();
    
}