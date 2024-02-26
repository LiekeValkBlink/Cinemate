using System.Net.Http.Json;
using Cinemate.Models.Dto;
using Cinemate.Web.Services.Contracts;

namespace Cinemate.Web.Services;

public class TheaterService: ITheaterService
{
    private readonly HttpClient _httpClient;

    public TheaterService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async Task<IEnumerable<TheaterDto>> GetAllTheaters()
    {
        var response = await _httpClient.GetAsync("api/theater");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<IEnumerable<TheaterDto>>();
    }
    

    public async Task<TheaterDto> GetSingleTheater(int id)
    {
        var response = await _httpClient.GetAsync($"api/theater/{id}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<TheaterDto>();
    }

    public async Task<TheaterDto> AddTheater(TheaterDto theaterDto)
    {
        var response = await _httpClient.PostAsJsonAsync("api/theater", theaterDto);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<TheaterDto>();
    }

    public async Task<TheaterDto> UpdateTheater(TheaterDto theaterDto)
    {
        var response = await _httpClient.PutAsJsonAsync($"api/theater/{theaterDto.Id}", theaterDto);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<TheaterDto>();
    }

    public async Task DeleteTheater(int id)
    {
        var response = await _httpClient.DeleteAsync($"api/theater/{id}");
        response.EnsureSuccessStatusCode();
    }
}