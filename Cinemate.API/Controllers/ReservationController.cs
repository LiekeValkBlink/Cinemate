using Cinemate.API.Services;
using Cinemate.API.Services.ReservationService;
using Cinemate.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Cinemate.API.Controllers;


[Route("api/[controller]")]
[ApiController]
public class ReservationController : ControllerBase
{
    private readonly IReservationService _reservationService;

    public ReservationController(IReservationService reservationService)
    {
        _reservationService = reservationService;
    }

    // GET: api/Reservation
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ReservationDto>>> GetAllReservations()
    {
        try
        {
            // Retrieve all reservations
            var reservations = await _reservationService.GetAllReservations();
            return Ok(reservations);
        }
        catch (Exception ex)
        {
            // Return 500 Internal Server Error if an exception occurs
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    
    // POST: api/Reservation
    [HttpPost]
    public async Task<ActionResult<ReservationDto>> AddReservation(AddReservationDto reservation)
    {
        try
        {
            // Add a new reservation
            var addedReservation = await _reservationService.AddReservation(reservation);
            return Ok(addedReservation);
        }
        catch (Exception ex)
        {
            // Return 500 Internal Server Error if an exception occurs
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }

    // GET: api/Reservation/{id:int}
    [HttpGet("{id:int}")]
    public async Task<ActionResult<ReservationDto>> GetSingleReservation(int id)
    {
        try
        {
            // Retrieve a single reservation by ID
            var reservation = await _reservationService.GetSingleReservation(id);
            if (reservation != null)
            {
                return Ok(reservation);
            }
            // Return 404 Not Found if the reservation does not exist
            return NotFound("Reservation not found");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    // POST: api/Reservation/secretmovie
    [HttpPost("secretmovie")]
    public async Task<ActionResult<SecretMoviePreReservation>> AddSecretMovieReservation(SecretMovieDto secretMovie)
    {
        try
        {
            // Add a secret movie reservation
            var preReservation = await _reservationService.AddSecretMovieReservation(secretMovie);
            return Ok(preReservation);
        }
        catch (Exception ex)
        {
            // Return 500 Internal Server Error if an exception occurs
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
}
