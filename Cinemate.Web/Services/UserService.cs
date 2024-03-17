using System.Net.Http.Json;
using Cinemate.Models.Dto;
using Cinemate.Web.Services.Contracts;

namespace Cinemate.Web.Services;

// Service class for managing users
public class UserService : IUserService
{
    private readonly HttpClient _httpClient; // HttpClient for making HTTP requests

    // Constructor to initialize the service with an instance of HttpClient
    public UserService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    // Method to asynchronously get all users
    public async Task<IEnumerable<UserDto>> GetAllUsers()
    {
        // Send a GET request to the API endpoint to retrieve all users
        var response = await _httpClient.GetAsync("api/user");
        response.EnsureSuccessStatusCode(); // Ensure the request was successful
        // Deserialize the JSON response body into a collection of UserDto objects and return it
        var users = await response.Content.ReadFromJsonAsync<IEnumerable<UserDto>>();
        return users;
    }

    // Method to asynchronously get a user by their ID
    public async Task<UserDto> GetUserById(int id)
    {
        // Send a GET request to the API endpoint to retrieve a specific user by their ID
        var response = await _httpClient.GetAsync($"api/user/{id}");
        response.EnsureSuccessStatusCode(); // Ensure the request was successful
        // Deserialize the JSON response body into a UserDto object and return it
        var user = await response.Content.ReadFromJsonAsync<UserDto>();
        return user;
    }

    // Method to asynchronously create a new user
    public async Task<UserDto> CreateUser(AddUserDto user)
    {
        // Send a POST request to the API endpoint to create a new user, with the provided data
        var response = await _httpClient.PostAsJsonAsync("api/user", user);
        response.EnsureSuccessStatusCode(); // Ensure the request was successful
        // Deserialize the JSON response body into a UserDto object and return it
        var createdUser = await response.Content.ReadFromJsonAsync<UserDto>();
        return createdUser;
    }

    // Method to asynchronously update an existing user
    public async Task<UserDto> UpdateUser(int id, UserDto user)
    {
        // Send a PUT request to the API endpoint to update an existing user with the provided ID and data
        var response = await _httpClient.PutAsJsonAsync($"api/user/{id}", user);
        response.EnsureSuccessStatusCode(); // Ensure the request was successful
        // Deserialize the JSON response body into a UserDto object and return it
        var updatedUser = await response.Content.ReadFromJsonAsync<UserDto>();
        return updatedUser;
    }

    // Method to asynchronously delete a user by their ID
    public async Task DeleteUser(int id)
    {
        // Send a DELETE request to the API endpoint to delete a user by their ID
        var response = await _httpClient.DeleteAsync($"api/user/{id}");
        response.EnsureSuccessStatusCode(); // Ensure the request was successful
    }
}