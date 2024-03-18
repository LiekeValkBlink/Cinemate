using System.Net.Http.Json;
using Cinemate.Models.Dto;
using Cinemate.Web.Services.Contracts;

namespace Cinemate.Web.Services;

// Service class for managing theaters
public class TheaterService : ITheaterService
{
    private readonly HttpClient _httpClient; // HttpClient for making HTTP requests

    // Constructor to initialize the service with an instance of HttpClient
    public TheaterService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    // Method to asynchronously get all theaters
    public async Task<IEnumerable<TheaterDto>> GetAllTheaters()
    {
        // Send a GET request to the API endpoint to retrieve all theaters
        var response = await _httpClient.GetAsync("api/theater");
        response.EnsureSuccessStatusCode(); // Ensure the request was successful
        // Deserialize the JSON response body into a collection of TheaterDto objects and return it
        return await response.Content.ReadFromJsonAsync<IEnumerable<TheaterDto>>();
    }
    
    // Method to asynchronously get a single theater by its ID
    public async Task<TheaterDto> GetSingleTheater(int id)
    {
        // Send a GET request to the API endpoint to retrieve a specific theater by its ID
        var response = await _httpClient.GetAsync($"api/theater/{id}");
        response.EnsureSuccessStatusCode(); // Ensure the request was successful
        // Deserialize the JSON response body into a TheaterDto object and return it
        return await response.Content.ReadFromJsonAsync<TheaterDto>();
    }

    // Method to asynchronously add a new theater
    public async Task<TheaterDto> AddTheater(TheaterDto theaterDto)
    {
        // Send a POST request to the API endpoint to add a new theater, with the provided data
        var response = await _httpClient.PostAsJsonAsync("api/theater", theaterDto);
        response.EnsureSuccessStatusCode(); // Ensure the request was successful
        // Deserialize the JSON response body into a TheaterDto object and return it
        return await response.Content.ReadFromJsonAsync<TheaterDto>();
    }

    // Method to asynchronously update an existing theater
    public async Task<TheaterDto> UpdateTheater(TheaterDto theaterDto)
    {
        // Send a PUT request to the API endpoint to update an existing theater, with the provided data
        var response = await _httpClient.PutAsJsonAsync($"api/theater/{theaterDto.Id}", theaterDto);
        response.EnsureSuccessStatusCode(); // Ensure the request was successful
        // Deserialize the JSON response body into a TheaterDto object and return it
        return await response.Content.ReadFromJsonAsync<TheaterDto>();
    }

    // Method to asynchronously delete a theater by its ID
    public async Task DeleteTheater(int id)
    {
        // Send a DELETE request to the API endpoint to delete a theater by its ID
        var response = await _httpClient.DeleteAsync($"api/theater/{id}");
        response.EnsureSuccessStatusCode(); // Ensure the request was successful
    }
}