using Cinemate.Models.Dto;

namespace Cinemate.Web.Services.Contracts;

public interface IReservationService
{
    Task<PreReservationDto> GetLocalPreReservation();
    Task<SecretMoviePreReservation> GetLocalSecretMoviePreReservation();
    Task SetLocalPreReservation(PreReservationDto preReservation);
    Task SetLocalSecretMoviePreReservation(SecretMoviePreReservation preReservation);
    Task<IEnumerable<ReservationDto>> GetAllReservations();
    Task<ReservationDto> AddReservation(AddReservationDto reservation);
    Task<ReservationDto> GetSingleReservation(int id);
    Task<SecretMoviePreReservation> AddSecretMovieReservation(SecretMovieDto secretMovie);
}