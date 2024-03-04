using Cinemate.API.Services.TheatherService;
using Cinemate.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Cinemate.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SeatsController : ControllerBase
{
    private readonly ISeatsService _seatsService;

    public SeatsController(ISeatsService seatsService)
    {
        _seatsService = seatsService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<SeatsWInfoDto>>> GetAllSeats()
    {
        var seats = await _seatsService.GetAllSeats();
        return Ok(seats);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<SeatsWInfoDto>> GetSeatById(int id)
    {
        var seat = await _seatsService.GetSeatById(id);
        if (seat == null)
        {
            return NotFound();
        }
        return Ok(seat);
    }
    
    [HttpGet("theaterroom/{theaterRoomId}")]
    public async Task<ActionResult<IEnumerable<SeatsWInfoDto>>> GetSeatsByTheaterRoomId(int theaterRoomId)
    {
        try
        {
            var seats = await _seatsService.GetSeatsByTheaterRoomId(theaterRoomId);
            return Ok(seats);
        }
        catch (Exception ex)
        {
            // Log the error
            return StatusCode(500, "An error occurred while fetching seats.");
        }
    }

    [HttpPost]
    public async Task<ActionResult<SeatsWInfoDto>> AddSeat([FromBody] AddSeatsDto seatDto)
    {
        var newSeat = await _seatsService.AddSeat(seatDto);
        return CreatedAtAction(nameof(GetSeatById), new { id = newSeat.Id }, newSeat);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateSeat(int id, [FromBody] SeatsDto seatDto)
    {
        var updatedSeat = await _seatsService.UpdateSeat(id, seatDto);
        if (updatedSeat == null)
        {
            return NotFound();
        }
        return Ok(updatedSeat);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteSeat(int id)
    {
        await _seatsService.DeleteSeat(id);
        return Ok();
    }
}