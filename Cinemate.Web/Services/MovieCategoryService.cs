using System.Net.Http.Json;
using Cinemate.Models.Dto;
using Cinemate.Web.Services.Contracts;

namespace Cinemate.Web.Services;

// Service class responsible for handling movie category-related operations
public class MovieCategoryService : IMovieCategoryService
{
    private readonly HttpClient _httpClient;

    // Constructor to initialize the service with an HttpClient instance
    public MovieCategoryService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    // Method to fetch all movie categories from the API
    public async Task<IEnumerable<MovieCategoryDto>> GetAllMovieCategories()
    {
        var response = await _httpClient.GetAsync("api/MovieCategory");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<IEnumerable<MovieCategoryDto>>();
    }

    // Method to fetch a specific movie category by its ID from the API
    public async Task<MovieCategoryDto> GetMovieCategory(int id)
    {
        var response = await _httpClient.GetAsync($"api/MovieCategory/{id}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<MovieCategoryDto>();
    }

    // Method to add a new movie category via the API
    public async Task<MovieCategoryDto> AddMovieCategory(AddMovieCategoryDto movieCategoryDto)
    {
        var response = await _httpClient.PostAsJsonAsync("api/MovieCategory", movieCategoryDto);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<MovieCategoryDto>();
    }

    // Method to update an existing movie category via the API
    public async Task<MovieCategoryDto> UpdateMovieCategory(MovieCategoryDto movieCategoryDto)
    {
        var response = await _httpClient.PutAsJsonAsync($"api/MovieCategory/{movieCategoryDto.Id}", movieCategoryDto);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<MovieCategoryDto>();
    }

    // Method to delete a movie category by its ID via the API
    public async Task DeleteMovieCategory(int id)
    {
        var response = await _httpClient.DeleteAsync($"api/MovieCategory/{id}");
        response.EnsureSuccessStatusCode();
    }
}