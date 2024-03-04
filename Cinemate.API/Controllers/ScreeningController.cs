using Cinemate.API.Services.ScreeningService;
using Cinemate.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Cinemate.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ScreeningController: ControllerBase
{
    private readonly IScreeningService _screeningService;

    public ScreeningController(IScreeningService screeningService)
    {
        _screeningService = screeningService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ScreeningWithInfoDto>>> GetAllScreenings()
    {
        try
        {
            var screenings = await _screeningService.GetAllScreenings();
            return Ok(screenings);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ScreeningWithInfoDto>> GetScreening(int id)
    {
        try
        {
            var screening = await _screeningService.GetScreening(id);
            if (screening == null)
                return NotFound();

            return Ok(screening);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }

    [HttpPost]
    public async Task<ActionResult<ScreeningWithInfoDto>> AddScreening([FromBody] AddScreeningDto screeningDto)
    {
        try
        {
            var addedScreening = await _screeningService.AddScreening(screeningDto);
            return CreatedAtAction(nameof(GetScreening), new { id = addedScreening.Id }, addedScreening);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<ScreeningWithInfoDto>> UpdateScreening(int id, [FromBody] ScreeningDto screeningDto)
    {
        try
        {
            screeningDto.Id = id; // Ensure ID consistency
            var updatedScreening = await _screeningService.UpdateScreening(screeningDto);
            if (updatedScreening == null)
                return NotFound();

            return Ok(updatedScreening);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteScreening(int id)
    {
        try
        {
            await _screeningService.DeleteScreening(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
}