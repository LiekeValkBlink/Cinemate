using Cinemate.Models.Dto;

namespace Cinemate.Web.Services.Contracts;

public interface IReservationService
{
   
    Task<SecretMoviePreReservation> AddSecretMovieReservation(SecretMovieDto SecretMovieDto);
  
}