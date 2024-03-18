using System.Net;
using System.Net.Http.Json;
using Cinemate.Models.Dto;
using Cinemate.Web.Services.Contracts;

namespace Cinemate.Web.Services;

// Service class responsible for handling seat-related operations
public class SeatsService : ISeatsService
{
    private readonly HttpClient _httpClient;

    // Constructor to initialize the service with an HttpClient instance
    public SeatsService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    // Method to fetch all seats from the API
    public async Task<IEnumerable<SeatsWInfoDto>> GetAllSeats()
    {
        try
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<SeatsWInfoDto>>("api/Seats");
        }
        catch (HttpRequestException ex)
        {
            // Log the exception or handle it as needed
            Console.WriteLine($"Error retrieving seats: {ex.Message}");
            throw;
        }
    }

    // Method to fetch seats by theater room ID from the API
    public async Task<IEnumerable<SeatsWInfoDto>> GetSeatsByTheaterRoomId(int theaterRoomId)
    {
        try
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<SeatsWInfoDto>>($"api/Seats/TheaterRoom/{theaterRoomId}");
        }
        catch (HttpRequestException ex)
        {
            // Log the exception or handle it as needed
            Console.WriteLine($"Error retrieving seats by theater room ID: {ex.Message}");
            throw;
        }
    }

    // Method to fetch reserved seats by screening ID from the API
    public async Task<IEnumerable<ReservedSeatDto>> GetReservedSeatsByScreeningId(int screeningId)
    {
        try
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<ReservedSeatDto>>($"api/Seats/reserved-seats/{screeningId}");
        }
        catch (Exception e)
        {
            // Log the exception or handle it as needed
            Console.WriteLine(e);
            throw;
        }
    }

    // Method to fetch a single seat by its ID from the API
    public async Task<SeatsWInfoDto> GetSeatById(int id)
    {
        try
        {
            return await _httpClient.GetFromJsonAsync<SeatsWInfoDto>($"api/Seats/{id}");
        }
        catch (HttpRequestException ex)
        {
            // Log the exception or handle it as needed
            Console.WriteLine($"Error retrieving seat by ID: {ex.Message}");
            throw;
        }
    }

    // Method to add a new seat via the API
    public async Task<SeatsWInfoDto> AddSeat(AddSeatsDto seat)
    {
        try
        {
            var response = await _httpClient.PostAsJsonAsync("api/Seats", seat);
            response.EnsureSuccessStatusCode(); // Throw if HTTP error status code
            return await response.Content.ReadFromJsonAsync<SeatsWInfoDto>();
        }
        catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.BadRequest)
        {
            // Handle specific HTTP 400 errors
            Console.WriteLine($"Error adding seat: {ex.Message}");
            return null;
        }
        catch (HttpRequestException ex)
        {
            // Log the exception or handle it as needed
            Console.WriteLine($"Error adding seat: {ex.Message}");
            throw;
        }
    }

    // Method to update an existing seat via the API
    public async Task<SeatsWInfoDto> UpdateSeat(int id, SeatsDto seat)
    {
        try
        {
            var response = await _httpClient.PutAsJsonAsync($"api/Seats/{id}", seat);
            response.EnsureSuccessStatusCode(); // Throw if HTTP error status code
            return await response.Content.ReadFromJsonAsync<SeatsWInfoDto>();
        }
        catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
        {
            // Handle specific HTTP 404 errors
            Console.WriteLine($"Seat not found: {ex.Message}");
            return null;
        }
        catch (HttpRequestException ex)
        {
            // Log the exception or handle it as needed
            Console.WriteLine($"Error updating seat: {ex.Message}");
            throw;
        }
    }

    // Method to delete a seat by its ID via the API
    public async Task DeleteSeat(int id)
    {
        try
        {
            var response = await _httpClient.DeleteAsync($"api/Seats/{id}");
            response.EnsureSuccessStatusCode(); // Throw if HTTP error status code
        }
        catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
        {
            // Handle specific HTTP 404 errors
            Console.WriteLine($"Seat not found: {ex.Message}");
        }
        catch (HttpRequestException ex)
        {
            // Log the exception or handle it as needed
            Console.WriteLine($"Error deleting seat: {ex.Message}");
            throw;
        }
    }
}
