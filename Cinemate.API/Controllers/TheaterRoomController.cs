using Cinemate.API.Services.TheatherService;
using Cinemate.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Cinemate.API.Controllers;


[Route("api/[controller]")]
[ApiController]
public class TheaterRoomController: ControllerBase
{
    private readonly ITheaterRoomService _theaterRoomService;
    private readonly ITheaterService _theaterService;

    public TheaterRoomController(ITheaterRoomService theaterRoomService, ITheaterService theaterService)
    {
        _theaterRoomService = theaterRoomService;
        _theaterService = theaterService;
    }
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<TheaterRoomsDto>>> GetAllTheaterRooms()
    {
        var theaterRooms = await _theaterRoomService.GetAllTheaterRooms();
        return Ok(theaterRooms);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TheaterRoomsDto>> GetSingleTheaterRoom(int id)
    {
        var theaterRoom = await _theaterRoomService.GetSingleTheaterRoom(id);
        if (theaterRoom == null)
        {
            return NotFound();
        }
        return Ok(theaterRoom);
    }

    [HttpPost]
    public async Task<ActionResult<TheaterRoomsDto>> AddTheaterRoom(AddOrUpdateTheaterRoomDto theaterRoomDto)
    {
        
        // Check if the theater ID exists
        var theater = await _theaterService.GetSingleTheater(theaterRoomDto.TheaterId);
        if (theater == null)
        {
            throw new ArgumentException("Theater with the provided ID does not exist");
        }

        var addedTheaterRoom = await _theaterRoomService.AddTheaterRoom(theaterRoomDto);
        return CreatedAtAction(nameof(GetSingleTheaterRoom), new { id = addedTheaterRoom.Id }, addedTheaterRoom);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<TheaterRoomsDto>> UpdateTheaterRoom(int id, AddOrUpdateTheaterRoomDto theaterRoomDto)
    {
        if (id != theaterRoomDto.Id)
        {
            return BadRequest("Theater room ID mismatch");
        }

        try
        {
            var updatedTheaterRoom = await _theaterRoomService.UpdateTheaterRoom(theaterRoomDto);
            return Ok(updatedTheaterRoom);
        }
        catch (ArgumentException ex)
        {
            return NotFound(ex.Message);
        }
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteTheaterRoom(int id)
    {
        try
        {
            await _theaterRoomService.DeleteTheaterRoom(id);
            return NoContent();
        }
        catch (ArgumentException ex)
        {
            return NotFound(ex.Message);
        }
    }
}