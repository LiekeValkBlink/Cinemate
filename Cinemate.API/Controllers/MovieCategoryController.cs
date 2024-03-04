using Cinemate.API.Services.CategoryService;
using Cinemate.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Cinemate.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MovieCategoryController: ControllerBase
{
    private readonly IMovieCategoryService _movieCategoryService;

    public MovieCategoryController(IMovieCategoryService movieCategoryService)
    {
        _movieCategoryService = movieCategoryService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<MovieCategoryDto>>> GetAllMovieCategories()
    {
        try
        {
            var movieCategories = await _movieCategoryService.GetAllMovieCategories();
            return Ok(movieCategories);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<MovieCategoryDto>> GetMovieCategory(int id)
    {
        try
        {
            var movieCategory = await _movieCategoryService.GetMovieCategory(id);
            if (movieCategory == null)
            {
                return NotFound();
            }
            return Ok(movieCategory);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }

    [HttpPost]
    public async Task<ActionResult<MovieCategoryDto>> AddMovieCategory([FromBody] AddMovieCategoryDto movieCategoryDto)
    {
        try
        {
            var addedMovieCategory = await _movieCategoryService.AddMovieCategory(movieCategoryDto);
            return CreatedAtAction(nameof(GetMovieCategory), new { id = addedMovieCategory.Id }, addedMovieCategory);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<MovieCategoryDto>> UpdateMovieCategory(int id, [FromBody] MovieCategoryDto movieCategoryDto)
    {
        try
        {
            if (id != movieCategoryDto.Id)
            {
                return BadRequest("ID mismatch");
            }

            var updatedMovieCategory = await _movieCategoryService.UpdateMovieCategory(movieCategoryDto);
            return Ok(updatedMovieCategory);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteMovieCategory(int id)
    {
        try
        {
            await _movieCategoryService.DeleteMovieCategory(id);
            return Ok();
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
}