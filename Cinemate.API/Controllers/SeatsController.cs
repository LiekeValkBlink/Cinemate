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

    // GET: api/Seats
    [HttpGet]
    public async Task<ActionResult<IEnumerable<SeatsWInfoDto>>> GetAllSeats()
    {
        // Retrieve all seats
        var seats = await _seatsService.GetAllSeats();
        return Ok(seats);
    }

    // GET: api/Seats/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<SeatsWInfoDto>> GetSeatById(int id)
    {
        // Retrieve a single seat by ID
        var seat = await _seatsService.GetSeatById(id);
        if (seat == null)
        {
            return NotFound();
        }
        return Ok(seat);
    }
    
    // GET: api/Seats/theaterroom/{theaterRoomId}
    [HttpGet("theaterroom/{theaterRoomId}")]
    public async Task<ActionResult<IEnumerable<SeatsWInfoDto>>> GetSeatsByTheaterRoomId(int theaterRoomId)
    {
        try
        {
            // Retrieve seats by theater room ID
            var seats = await _seatsService.GetSeatsByTheaterRoomId(theaterRoomId);
            return Ok(seats);
        }
        catch (Exception ex)
        {
            // Log and return 500 Internal Server Error if an exception occurs
            return StatusCode(500, "An error occurred while fetching seats.");
        }
    }

    // POST: api/Seats
    [HttpPost]
    public async Task<ActionResult<SeatsWInfoDto>> AddSeat([FromBody] AddSeatsDto seatDto)
    {
        // Add a new seat
        var newSeat = await _seatsService.AddSeat(seatDto);
        return CreatedAtAction(nameof(GetSeatById), new { id = newSeat.Id }, newSeat);
    }

    // PUT: api/Seats/{id}
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateSeat(int id, [FromBody] SeatsDto seatDto)
    {
        // Update an existing seat
        var updatedSeat = await _seatsService.UpdateSeat(id, seatDto);
        if (updatedSeat == null)
        {
            return NotFound();
        }
        return Ok(updatedSeat);
    }

    // DELETE: api/Seats/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteSeat(int id)
    {
        // Delete a seat by ID
        await _seatsService.DeleteSeat(id);
        return Ok();
    }
    
    // GET: api/Seats/reserved-seats/{screeningId}
    [HttpGet("reserved-seats/{screeningId}")]
    public async Task<ActionResult<IEnumerable<SeatsWInfoDto>>> GetReservedSeatsByScreeningId(int screeningId)
    {
        try
        {
            // Retrieve reserved seats by screening ID
            var reservedSeats = await _seatsService.GetReservedSeatsByScreeningId(screeningId);
            return Ok(reservedSeats);
        }
        catch (Exception ex)
        {
            // Return 500 Internal Server Error if an exception occurs
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
}
