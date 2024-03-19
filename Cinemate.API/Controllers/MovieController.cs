using Cinemate.API.Services.MovieService;
using Cinemate.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Cinemate.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MovieController : ControllerBase
{
    private readonly IMovieService _movieService;

    public MovieController(IMovieService movieService)
    {
        _movieService = movieService;
    }

    // POST: api/Movie/image/poster
    [HttpPost("image/poster")]
    public async Task<ActionResult> UploadFile(IFormFile file)
    {
        // Check if file is provided
        if (file == null)
            return BadRequest("File is required");

        // Get the file name
        var fileName = file.FileName;
        // Construct the file path
        var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot/Images/posters", fileName);

        // Open a file stream to write the file
        await using var fileStream = new FileStream(filePath, FileMode.Create);
        // Copy the content of the uploaded file to the file stream
        await file.CopyToAsync(fileStream);

        // Construct the URL to access the uploaded image
        var imageUrl = $"{Request.Scheme}://{Request.Host}/Images/posters/{fileName}";

        return Ok(imageUrl);
    }

    // POST: api/Movie/image/screenshot
    [HttpPost("image/screenshot")]
    public async Task<ActionResult> UploadPosterFile(IFormFile file)
    {
        // Check if file is provided
        if (file == null)
            return BadRequest("File is required");

        // Get the file name
        var fileName = file.FileName;
        // Construct the file path
        var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot/Images/screenshots", fileName);

        // Open a file stream to write the file
        await using var fileStream = new FileStream(filePath, FileMode.Create);
        // Copy the content of the uploaded file to the file stream
        await file.CopyToAsync(fileStream);

        // Construct the URL to access the uploaded image
        var imageUrl = $"{Request.Scheme}://{Request.Host}/Images/screenshots/{fileName}";

        return Ok(imageUrl);
    }

    // GET: api/Movie
    [HttpGet]
    public async Task<ActionResult<IEnumerable<MovieWithCategoryDto>>> GetAllMovies()
    {
        var movies = await _movieService.GetAllMovies();
        return Ok(movies);
    }

    // GET: api/Movie/{id:int}
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

    // POST: api/Movie
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
            return BadRequest($"An error occurred: {e.Message}");
        }

    }

    // DELETE: api/Movie
    [HttpDelete("{id}")]
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
