using Cinemate.API.Services.ScreeningService;
using Cinemate.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Cinemate.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ScreeningController : ControllerBase
{
    private readonly IScreeningService _screeningService;

    public ScreeningController(IScreeningService screeningService)
    {
        _screeningService = screeningService;
    }

    // GET: api/Screening
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ScreeningWithInfoDto>>> GetAllScreenings()
    {
        try
        {
            // Retrieve all screenings
            var screenings = await _screeningService.GetAllScreenings();
            return Ok(screenings);
        }
        catch (Exception ex)
        {
            // Return 500 Internal Server Error if an exception occurs
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }

    // GET: api/Screening/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<ScreeningWithInfoDto>> GetScreening(int id)
    {
        try
        {
            // Retrieve a single screening by ID
            var screening = await _screeningService.GetScreening(id);
            if (screening == null)
                return NotFound();

            return Ok(screening);
        }
        catch (Exception ex)
        {
            // Return 500 Internal Server Error if an exception occurs
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }

    // POST: api/Screening
    [HttpPost]
    public async Task<ActionResult<ScreeningWithInfoDto>> AddScreening([FromBody] AddScreeningDto screeningDto)
    {
        try
        {
            // Add a new screening
            var addedScreening = await _screeningService.AddScreening(screeningDto);
            return CreatedAtAction(nameof(GetScreening), new { id = addedScreening.Id }, addedScreening);
        }
        catch (ArgumentException ex)
        {
            // Return 400 Bad Request if an argument exception occurs
            return BadRequest(ex.Message);
        }
        catch (Exception ex)
        {
            // Return 500 Internal Server Error if an exception occurs
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }

    // PUT: api/Screening/{id}
    [HttpPut("{id}")]
    public async Task<ActionResult<ScreeningWithInfoDto>> UpdateScreening(int id, [FromBody] ScreeningDto screeningDto)
    {
        try
        {
            // Ensure ID consistency
            screeningDto.Id = id;
            // Update the screening
            var updatedScreening = await _screeningService.UpdateScreening(screeningDto);
            if (updatedScreening == null)
                return NotFound();

            return Ok(updatedScreening);
        }
        catch (ArgumentException ex)
        {
            // Return 400 Bad Request if an argument exception occurs
            return BadRequest(ex.Message);
        }
        catch (Exception ex)
        {
            // Return 500 Internal Server Error if an exception occurs
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }

    // DELETE: api/Screening/{id}
    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteScreening(int id)
    {
        try
        {
            // Delete the screening by ID
            await _screeningService.DeleteScreening(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            // Return 500 Internal Server Error if an exception occurs
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
}
