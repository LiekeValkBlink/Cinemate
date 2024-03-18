using System.Net.Http.Json;
using Cinemate.Models.Dto;
using Cinemate.Web.Services.Contracts;

namespace Cinemate.Web.Services;

// Service class responsible for handling screening-related operations
public class ScreeningService : IScreeningService
{
    private readonly HttpClient _httpClient;

    // Constructor to initialize the service with an HttpClient instance
    public ScreeningService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    // Method to fetch all screenings from the API
    public async Task<IEnumerable<ScreeningWithInfoDto>> GetAllScreenings()
    {
        // Send GET request to API to fetch all screenings
        var response = await _httpClient.GetAsync("api/screening");
        response.EnsureSuccessStatusCode(); // Throws if HTTP response status is not a success code
        return await response.Content.ReadFromJsonAsync<IEnumerable<ScreeningWithInfoDto>>();
    }

    // Method to fetch a single screening by its ID from the API
    public async Task<ScreeningWithInfoDto> GetScreening(int id)
    {
        // Send GET request to API to fetch the screening with the specified ID
        var response = await _httpClient.GetAsync($"api/screening/{id}");
        response.EnsureSuccessStatusCode(); // Throws if HTTP response status is not a success code
        return await response.Content.ReadFromJsonAsync<ScreeningWithInfoDto>();
    }

    // Method to add a new screening via the API
    public async Task<ScreeningWithInfoDto> AddScreening(AddScreeningDto screeningDto)
    {
        // Send POST request to API to add a new screening
        var response = await _httpClient.PostAsJsonAsync("api/screening", screeningDto);
        response.EnsureSuccessStatusCode(); // Throws if HTTP response status is not a success code
        return await response.Content.ReadFromJsonAsync<ScreeningWithInfoDto>();
    }

    // Method to update an existing screening via the API
    public async Task<ScreeningWithInfoDto> UpdateScreening(ScreeningDto screeningDto)
    {
        // Send PUT request to API to update the screening with the specified ID
        var response = await _httpClient.PutAsJsonAsync($"api/screening/{screeningDto.Id}", screeningDto);
        response.EnsureSuccessStatusCode(); // Throws if HTTP response status is not a success code
        return await response.Content.ReadFromJsonAsync<ScreeningWithInfoDto>();
    }

    // Method to delete a screening by its ID via the API
    public async Task DeleteScreening(int id)
    {
        // Send DELETE request to API to delete the screening with the specified ID
        var response = await _httpClient.DeleteAsync($"api/screening/{id}");
        response.EnsureSuccessStatusCode(); // Throws if HTTP response status is not a success code
    }
}