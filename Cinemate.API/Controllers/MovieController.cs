using Cinemate.API.Services.MovieService;
using Cinemate.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Cinemate.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MovieController: ControllerBase
{
    private readonly IMovieService _movieService;

    public MovieController(IMovieService movieService)
    {
        _movieService = movieService;
    }

    [HttpPost("image/poster")]
    public async Task<ActionResult> UploadFile(IFormFile file)
    {
        if (file == null)
            return BadRequest("File is required");
        
        // Get the file name
        var fileName = file.FileName;
        // Get the extension
        var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\Images\posters", fileName);
        
        await using var fileStream = new FileStream(filePath, FileMode.Create);
        
        // Copy the content to the new stream
        await file.CopyToAsync(fileStream);
        

        // Construct the URL to access the uploaded image
        var imageUrl = $"{Request.Scheme}://{Request.Host}/Images/poster/{fileName}";

        return Ok(imageUrl);
    }
    
    [HttpPost("image/screenshot")]
    public async Task<ActionResult> UploadPosterFile(IFormFile file)
    {
        if (file == null)
            return BadRequest("File is required");
        
        // Get the file name
        var fileName = file.FileName;
        // Get the extension
        var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\Images\screenshots", fileName);
        
        await using var fileStream = new FileStream(filePath, FileMode.Create);
        
        // Copy the content to the new stream
        await file.CopyToAsync(fileStream);
        

        // Construct the URL to access the uploaded image
        var imageUrl = $"{Request.Scheme}://{Request.Host}/Images/screenshots/{fileName}";

        return Ok(imageUrl);
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<MovieWithCategoryDto>>> GetAllMovies()
    {
        var movies = await _movieService.GetAllMovies();
        return Ok(movies);
    }

    [HttpGet("{id:int}")]
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