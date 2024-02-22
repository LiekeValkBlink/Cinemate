using System.Net.Http.Json;
using Cinemate.Models.Dto;
using Cinemate.Web.Services.Contracts;

namespace Cinemate.Web.Services;

public class MovieCategoryService: IMovieCategoryService
{
    private readonly HttpClient _httpClient;

    public MovieCategoryService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<MovieCategoryDto>> GetAllMovieCategories()
    {
        var response = await _httpClient.GetAsync("api/MovieCategory");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<IEnumerable<MovieCategoryDto>>();
    }

    public async Task<MovieCategoryDto> GetMovieCategory(int id)
    {
        var response = await _httpClient.GetAsync($"api/MovieCategory/{id}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<MovieCategoryDto>();
    }

    public async Task<MovieCategoryDto> AddMovieCategory(MovieCategoryDto movieCategoryDto)
    {
        var response = await _httpClient.PostAsJsonAsync("api/MovieCategory", movieCategoryDto);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<MovieCategoryDto>();
    }

    public async Task<MovieCategoryDto> UpdateMovieCategory(MovieCategoryDto movieCategoryDto)
    {
        var response = await _httpClient.PutAsJsonAsync($"api/MovieCategory/{movieCategoryDto.Id}", movieCategoryDto);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<MovieCategoryDto>();
    }

    public async Task DeleteMovieCategory(int id)
    {
        var response = await _httpClient.DeleteAsync($"api/MovieCategory/{id}");
        response.EnsureSuccessStatusCode();
    }
}