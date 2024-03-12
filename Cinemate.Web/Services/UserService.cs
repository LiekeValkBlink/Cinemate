using System.Net.Http.Json;
using Cinemate.Models.Dto;
using Cinemate.Web.Services.Contracts;

namespace Cinemate.Web.Services;

public class UserService: IUserService
{
    private readonly HttpClient _httpClient;

    public UserService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<UserDto>> GetAllUsers()
    {
        var response = await _httpClient.GetAsync("api/user");
        response.EnsureSuccessStatusCode(); // Throw if not a success code.

        var users = await response.Content.ReadFromJsonAsync<IEnumerable<UserDto>>();
        return users;
    }

    public async Task<UserDto> GetUserById(int id)
    {
        var response = await _httpClient.GetAsync($"api/user/{id}");
        response.EnsureSuccessStatusCode(); // Throw if not a success code.

        var user = await response.Content.ReadFromJsonAsync<UserDto>();
        return user;
    }

    public async Task<UserDto> CreateUser(AddUserDto user)
    {
        var response = await _httpClient.PostAsJsonAsync("api/user", user);
        response.EnsureSuccessStatusCode(); // Throw if not a success code.

        var createdUser = await response.Content.ReadFromJsonAsync<UserDto>();
        return createdUser;
    }

    public async Task<UserDto> UpdateUser(int id, UserDto user)
    {
        var response = await _httpClient.PutAsJsonAsync($"api/user/{id}", user);
        response.EnsureSuccessStatusCode(); // Throw if not a success code.

        var updatedUser = await response.Content.ReadFromJsonAsync<UserDto>();
        return updatedUser;
    }

    public async Task DeleteUser(int id)
    {
        var response = await _httpClient.DeleteAsync($"api/user/{id}");
        response.EnsureSuccessStatusCode(); // Throw if not a success code.
    }
}