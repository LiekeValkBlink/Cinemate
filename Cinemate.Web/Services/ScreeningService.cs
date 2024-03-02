using System.Net.Http.Json;
using Cinemate.Models.Dto;
using Cinemate.Web.Services.Contracts;

namespace Cinemate.Web.Services;

public class ScreeningService: IScreeningService
{
    private readonly HttpClient _httpClient;

    public ScreeningService(HttpClient _httpClient)
    {
        this._httpClient = _httpClient;
    }

    public async Task<IEnumerable<ScreeningWithInfoDto>> GetAllScreenings()
    {
        var response = await _httpClient.GetAsync("api/screening");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<IEnumerable<ScreeningWithInfoDto>>();
    }

    public async Task<ScreeningWithInfoDto> GetScreening(int id)
    {
        var response = await _httpClient.GetAsync($"api/screening/{id}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<ScreeningWithInfoDto>();
    }

    public async Task<ScreeningWithInfoDto> AddScreening(AddScreeningDto screeningDto)
    {
        var response = await _httpClient.PostAsJsonAsync("api/screening", screeningDto);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<ScreeningWithInfoDto>();
    }

    public async Task<ScreeningWithInfoDto> UpdateScreening(ScreeningDto screeningDto)
    {
        var response = await _httpClient.PutAsJsonAsync($"api/screening/{screeningDto.Id}", screeningDto);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<ScreeningWithInfoDto>();
    }

    public async Task DeleteScreening(int id)
    {
        var response = await _httpClient.DeleteAsync($"api/screening/{id}");
        response.EnsureSuccessStatusCode();
    }
}