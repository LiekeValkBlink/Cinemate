using System.Net.Http.Json;
using Cinemate.Models.Dto;
using Cinemate.Web.Services.Contracts;

namespace Cinemate.Web.Services;

// Service class for managing theater rooms
public class TheaterRoomService : ITheaterRoomService
{
    private readonly HttpClient _httpClient; // HttpClient for making HTTP requests

    // Constructor to initialize the service with an instance of HttpClient
    public TheaterRoomService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    // Method to asynchronously get all theater rooms
    public async Task<IEnumerable<TheaterRoomsWInfoDto>> GetAllTheaterRooms()
    {
        // Send a GET request to the API endpoint to retrieve all theater rooms
        var response = await _httpClient.GetAsync("api/TheaterRoom");
        response.EnsureSuccessStatusCode(); // Ensure the request was successful
        // Deserialize the JSON response body into a collection of TheaterRoomsWInfoDto objects and return it
        return await response.Content.ReadFromJsonAsync<IEnumerable<TheaterRoomsWInfoDto>>();
    }

    // Method to asynchronously get a single theater room by its ID
    public async Task<TheaterRoomsWInfoDto> GetSingleTheaterRoom(int id)
    {
        // Send a GET request to the API endpoint to retrieve a specific theater room by its ID
        var response = await _httpClient.GetAsync($"api/TheaterRoom/{id}");
        response.EnsureSuccessStatusCode(); // Ensure the request was successful
        // Deserialize the JSON response body into a TheaterRoomsWInfoDto object and return it
        return await response.Content.ReadFromJsonAsync<TheaterRoomsWInfoDto>();
    }

    // Method to asynchronously add a new theater room
    public async Task<TheaterRoomsWInfoDto> AddTheaterRoom(AddTheaterRoomDto theaterRoomDto)
    {
        // Send a POST request to the API endpoint to add a new theater room, with the provided data
        var response = await _httpClient.PostAsJsonAsync("api/TheaterRoom", theaterRoomDto);
        response.EnsureSuccessStatusCode(); // Ensure the request was successful
        // Deserialize the JSON response body into a TheaterRoomsWInfoDto object and return it
        return await response.Content.ReadFromJsonAsync<TheaterRoomsWInfoDto>();
    }

    // Method to asynchronously update an existing theater room
    public async Task<TheaterRoomsWInfoDto> UpdateTheaterRoom(TheaterRoomDto theaterRoomDto)
    {
        // Send a PUT request to the API endpoint to update an existing theater room, with the provided data
        var response = await _httpClient.PutAsJsonAsync($"api/TheaterRoom/{theaterRoomDto.Id}", theaterRoomDto);
        response.EnsureSuccessStatusCode(); // Ensure the request was successful
        // Deserialize the JSON response body into a TheaterRoomsWInfoDto object and return it
        return await response.Content.ReadFromJsonAsync<TheaterRoomsWInfoDto>();
    }

    // Method to asynchronously delete a theater room by its ID
    public async Task DeleteTheaterRoom(int id)
    {
        // Send a DELETE request to the API endpoint to delete a theater room by its ID
        var response = await _httpClient.DeleteAsync($"api/TheaterRoom/{id}");
        response.EnsureSuccessStatusCode(); // Ensure the request was successful
    }
}