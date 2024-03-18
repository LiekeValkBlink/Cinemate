using Cinemate.API.Services.TheatherService;
using Cinemate.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Cinemate.API.Controllers;


[Route("api/[controller]")]
[ApiController]
public class TheaterRoomController : ControllerBase
{
    private readonly ITheaterRoomService _theaterRoomService;
    private readonly ITheaterService _theaterService;

    public TheaterRoomController(ITheaterRoomService theaterRoomService, ITheaterService theaterService)
    {
        _theaterRoomService = theaterRoomService;
        _theaterService = theaterService;
    }
    
    // GET: api/TheaterRoom
    [HttpGet]
    public async Task<ActionResult<IEnumerable<TheaterRoomsWInfoDto>>> GetAllTheaterRooms()
    {
        // Retrieve all theater rooms
        var theaterRooms = await _theaterRoomService.GetAllTheaterRooms();
        return Ok(theaterRooms);
    }

    // GET: api/TheaterRoom/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<TheaterRoomsWInfoDto>> GetSingleTheaterRoom(int id)
    {
        // Retrieve a single theater room by ID
        var theaterRoom = await _theaterRoomService.GetSingleTheaterRoom(id);
        if (theaterRoom == null)
        {
            return NotFound(); // Return 404 if theater room is not found
        }
        return Ok(theaterRoom);
    }

    // POST: api/TheaterRoom
    [HttpPost]
    public async Task<ActionResult<TheaterRoomsWInfoDto>> AddTheaterRoom(AddTheaterRoomDto theaterRoomDto)
    {
        // Check if the theater ID exists
        var theater = await _theaterService.GetSingleTheater(theaterRoomDto.TheaterId);
        if (theater == null)
        {
            throw new ArgumentException("Theater with the provided ID does not exist");
        }

        // Add a new theater room
        var addedTheaterRoom = await _theaterRoomService.AddTheaterRoom(theaterRoomDto);
        return CreatedAtAction(nameof(GetSingleTheaterRoom), new { id = addedTheaterRoom.Id }, addedTheaterRoom);
    }

    // PUT: api/TheaterRoom/{id}
    [HttpPut("{id}")]
    public async Task<ActionResult<TheaterRoomsWInfoDto>> UpdateTheaterRoom(int id, TheaterRoomDto theaterRoomDto)
    {
        if (id != theaterRoomDto.Id)
        {
            return BadRequest("Theater room ID mismatch");
        }

        try
        {
            // Update an existing theater room
            var updatedTheaterRoom = await _theaterRoomService.UpdateTheaterRoom(theaterRoomDto);
            return Ok(updatedTheaterRoom);
        }
        catch (ArgumentException ex)
        {
            return NotFound(ex.Message);
        }
    }

    // DELETE: api/TheaterRoom/{id}
    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteTheaterRoom(int id)
    {
        try
        {
            // Delete a theater room by ID
            await _theaterRoomService.DeleteTheaterRoom(id);
            return NoContent(); // Return 204 if deletion is successful
        }
        catch (ArgumentException ex)
        {
            return NotFound(ex.Message);
        }
    }
}
