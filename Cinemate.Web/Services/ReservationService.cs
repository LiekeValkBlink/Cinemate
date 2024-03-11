using System.Net.Http.Json;
using Cinemate.Models.Dto;
using Cinemate.Web.Services.Contracts;

namespace Cinemate.Web.Services;

public class ReservationService : IReservationService
{
    private readonly HttpClient _httpClient;

    public ReservationService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<ReservationDto>> GetAllReservations()
    {
        try
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<ReservationDto>>("api/reservation");
        }
        catch (HttpRequestException ex)
        {
            throw new Exception("Failed to fetch reservations. Please try again later.", ex);
        }
    }

    public async Task<ReservationDto> AddReservation(AddReservationDto reservation)
    {
        try
        {
            var response = await _httpClient.PostAsJsonAsync("api/reservation", reservation);
            response.EnsureSuccessStatusCode(); // Throws if HTTP response status is not a success code
            return await response.Content.ReadFromJsonAsync<ReservationDto>();
        }
        catch (HttpRequestException ex)
        {
            throw new Exception("Failed to add reservation. Please try again later.", ex);
        }
    }

    public async Task<ReservationDto> GetSingleReservation(int id)
    {
        try
        {
            return await _httpClient.GetFromJsonAsync<ReservationDto>($"api/reservation/{id}");
        }
        catch (HttpRequestException ex)
        {
            throw new Exception($"Failed to fetch reservation with ID {id}. Please try again later.", ex);
        }
    }

    public async Task<SecretMoviePreReservation> AddSecretMovieReservation(SecretMovieDto secretMovie)
    {
        try
        {
            var response = await _httpClient.PostAsJsonAsync("api/reservation/secretmovie", secretMovie);
            response.EnsureSuccessStatusCode(); // Throws if HTTP response status is not a success code
            return await response.Content.ReadFromJsonAsync<SecretMoviePreReservation>();
        }
        catch (HttpRequestException ex)
        {
            throw new Exception("Failed to add secret movie reservation. Please try again later.", ex);
        }
    }
}