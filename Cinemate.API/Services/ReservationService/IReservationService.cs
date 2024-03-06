using Cinemate.Models.Dto;

namespace Cinemate.API.Services.ReservationService;

public interface IReservationService
{
    Task<IEnumerable<ReservationDto>> GetAllReservations();
    Task<ReservationDto> AddReservation(AddReservationDto reservation);

    Task<ReservationDto> GetSingleReservation(int id);

    Task<ReservationDto> AddSecretMovieReservation(SecretMovieDto secretMovie);
}