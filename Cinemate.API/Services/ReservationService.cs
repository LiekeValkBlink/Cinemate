using Cinemate.Models.Dto;

namespace Cinemate.API.Services;

public interface ReservationService
{
    Task<ReservationDto> AddReservation();
}