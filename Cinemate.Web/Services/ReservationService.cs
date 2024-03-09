using System.Net.Http.Json;
using Cinemate.Models.Dto;
using Cinemate.Web.Services.Contracts;

namespace Cinemate.Web.Services;

public class ReservationService: IReservationService
{
    private readonly HttpClient _httpClient;

    public async Task<SecretMoviePreReservation> AddSecretMovieReservation(SecretMovieDto SecretMovieDto)
    {
        var response = await _httpClient.PostAsJsonAsync("api/Reservation/secretmovie", SecretMovieDto);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<SecretMoviePreReservation>();
    }

}