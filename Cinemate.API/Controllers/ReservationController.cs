using Cinemate.API.Services;
using Cinemate.API.Services.ReservationService;
using Cinemate.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Cinemate.API.Controllers;


[Route("api/[controller]")]
[ApiController]
public class ReservationController: ControllerBase
{
    private readonly IReservationService _reservationService;

    public ReservationController(IReservationService reservationService)
    {
        _reservationService = reservationService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ReservationDto>>> GetAllReservations()
    {
        try
        {
            var reservations = await _reservationService.GetAllReservations();
            return Ok(reservations);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    
    [HttpPost]
    public async Task<ActionResult<ReservationDto>> AddReservation(AddReservationDto reservation)
    {
        try
        {
            var addedReservation = await _reservationService.AddReservation(reservation);
            return Ok(addedReservation);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<ReservationDto>> GetSingleReservation(int id)
    {
        try
        {
            var reservation = await _reservationService.GetSingleReservation(id);
            if (reservation != null)
            {
                return Ok(reservation);
            }
            return NotFound("Reservation not found");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}