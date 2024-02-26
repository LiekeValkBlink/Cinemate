using System.Net.Http.Json;
using Cinemate.Models.Dto;
using Cinemate.Web.Services.Contracts;

namespace Cinemate.Web.Services;

public class TheaterRoomService: ITheaterRoomService
{
    private readonly HttpClient _httpClient;

    public TheaterRoomService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async Task<IEnumerable<TheaterRoomsDto>> GetAllTheaterRooms()
    {
        var response = await _httpClient.GetAsync("api/TheaterRoom");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<IEnumerable<TheaterRoomsDto>>();
    }

    public async Task<TheaterRoomsDto> GetSingleTheaterRoom(int id)
    {
        var response = await _httpClient.GetAsync($"api/TheaterRoom/{id}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<TheaterRoomsDto>();
    }

    public async Task<TheaterRoomsDto> AddTheaterRoom(AddOrUpdateTheaterRoomDto theaterRoomDto)
    {
        var response = await _httpClient.PostAsJsonAsync("api/TheaterRoom", theaterRoomDto);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<TheaterRoomsDto>();
    }

    public async Task<TheaterRoomsDto> UpdateTheaterRoom(AddOrUpdateTheaterRoomDto theaterRoomDto)
    {
        var response = await _httpClient.PutAsJsonAsync($"api/TheaterRoom/{theaterRoomDto.Id}", theaterRoomDto);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<TheaterRoomsDto>();
    }

    public async Task DeleteTheaterRoom(int id)
    {
        var response = await _httpClient.DeleteAsync($"api/TheaterRoom/{id}");
        response.EnsureSuccessStatusCode();
    }
}