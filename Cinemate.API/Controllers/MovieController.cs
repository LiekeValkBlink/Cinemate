using Cinemate.API.Services.MovieService;
using Cinemate.Models.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cinemate.API.Controllers;

[Route("api/[controller]"), Authorize]
[ApiController]
public class MovieController: ControllerBase
{
    private readonly IMovieService _movieService;

    public MovieController(IMovieService movieService)
    {
        _movieService = movieService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<MovieWithCategoryDto>>> GetAllMovies()
    {
        var movies = await _movieService.GetAllMovies();
        return Ok(movies);
    }

    [HttpGet("{id:int}"), Authorize]
    public async Task<ActionResult<MovieWithCategoryDto>> GetSingleMovie(int id)
    {
        var movie = await _movieService.GetSingleMovie(id);
        if (movie != null)
        {
            return Ok(movie);
        }
        return NotFound("Movie not found");
    }

    [HttpPost]
    public async Task<ActionResult<MovieWithCategoryDto>> AddMovie(MovieDto movieDto)
    {
        try
        {
            var result = await _movieService.AddMovie(movieDto);
            return Ok(result);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return BadRequest($"an error occured {e.Message}");
        }
        
    }

    [HttpDelete]
    public async Task<ActionResult> DeleteMovie(int id)
    {
        try
        {
            await _movieService.DeleteMovie(id);
            return Ok("Movie deleted");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return NotFound("Movie not found");
        }
    }
    
}