using Cinemate.API.Services.TheatherService;
using Cinemate.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Cinemate.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TheaterController: ControllerBase
{
    private readonly ITheaterService _theaterService;

    public TheaterController(ITheaterService theaterService)
    {
        _theaterService = theaterService;
    }
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<TheaterDto>>> GetAllTheaters()
    {
        var theaters = await _theaterService.GetAllTheaters();
        return Ok(theaters);
    }
    

    [HttpGet("{id}")]
    public async Task<ActionResult<TheaterDto>> GetSingleTheater(int id)
    {
        var theater = await _theaterService.GetSingleTheater(id);
        if (theater == null)
        {
            return NotFound(); // Return 404 if theater is not found
        }
        return Ok(theater);
    }

    [HttpPost]
    public async Task<ActionResult<TheaterDto>> AddTheater([FromBody] TheaterDto theaterDto)
    {
        try
        {
            var addedTheater = await _theaterService.AddTheater(theaterDto);
            return CreatedAtAction(nameof(GetSingleTheater), new { id = addedTheater.Id }, addedTheater);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message); // Return 400 with error message if something goes wrong
        }
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<TheaterDto>> UpdateTheater(int id, [FromBody] TheaterDto theaterDto)
    {
        if (id != theaterDto.Id)
        {
            return BadRequest("Theater ID mismatch");
        }

        try
        {
            var updatedTheater = await _theaterService.UpdateTheater(theaterDto);
            return Ok(updatedTheater);
        }
        catch (ArgumentException ex)
        {
            return NotFound(ex.Message);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteTheater(int id)
    {
        try
        {
            await _theaterService.DeleteTheater(id);
            return NoContent(); // Return 204 if deletion is successful
        }
        catch (ArgumentException ex)
        {
            return NotFound(ex.Message);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
}