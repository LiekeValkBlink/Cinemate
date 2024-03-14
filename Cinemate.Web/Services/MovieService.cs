using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Cinemate.Models.Dto;
using Cinemate.Web.Services.Contracts;
using Microsoft.AspNetCore.Components.Forms;

namespace Cinemate.Web.Services;

public class MovieService: IMovieService
{
    private readonly HttpClient _httpClient;

    public MovieService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<MovieWithCategoryDto>> GetMovies()
    {
        try
        {
            var response = await _httpClient.GetAsync("api/Movie");
            
            if (response.IsSuccessStatusCode)
            {
                if (response.StatusCode == HttpStatusCode.NoContent)
                {
                    return Enumerable.Empty<MovieWithCategoryDto>();
                }

                return await response.Content.ReadFromJsonAsync<IEnumerable<MovieWithCategoryDto>>();
            }
            var message = await response.Content.ReadAsStringAsync();
            throw new Exception($"Http status code: {response.StatusCode} message: {message}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<MovieWithCategoryDto> GetMovie(int id)
    {
        try
        {
            var response = await _httpClient.GetAsync($"api/Movie/{id}");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<MovieWithCategoryDto>();
            }
            var message = await response.Content.ReadAsStringAsync();
            throw new Exception($"Http status code: {response.StatusCode} message: {message}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<MovieWithCategoryDto> AddMovie(MovieDto movieDto)
    {
        try
        {
            var response = await _httpClient.PostAsJsonAsync("api/Movie", movieDto);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<MovieWithCategoryDto>();
            }
            var message = await response.Content.ReadAsStringAsync();
            throw new Exception($"Http status code: {response.StatusCode} message: {message}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<MovieWithCategoryDto> UpdateMovie(MovieDto movieDto)
    {
        try
        {
            var response = await _httpClient.PutAsJsonAsync($"api/Movie/{movieDto.Id}", movieDto);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<MovieWithCategoryDto>();
            }
            var message = await response.Content.ReadAsStringAsync();
            throw new Exception($"Http status code: {response.StatusCode} message: {message}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task DeleteMovie(int id)
    {
        try
        {
            var response = await _httpClient.DeleteAsync($"api/Movie/{id}");

            if (!response.IsSuccessStatusCode)
            {
                var message = await response.Content.ReadAsStringAsync();
                throw new Exception($"Http status code: {response.StatusCode} message: {message}");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task UploadMoviePosterImage(IBrowserFile file, int movieId)
    {
        if (file != null)
        {
            // Convert the IBrowserFile to a byte array
            using var memoryStream = new MemoryStream();
            await file.OpenReadStream().CopyToAsync(memoryStream);
            var fileBytes = memoryStream.ToArray();

            // Create the new file name
            var fileName = $"movie_{movieId}_image.jpg";
        
            // Create a ByteArrayContent from the byte array
            var fileContent = new ByteArrayContent(fileBytes);
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse(file.ContentType);
        
            // Create a multipart form content to send the file
            var multipartContent = new MultipartFormDataContent();
            multipartContent.Add(fileContent, "file", fileName);
        
            // Send the file to the server
            var response = await _httpClient.PostAsync($"api/Movie/image/poster", multipartContent);
        
            if (!response.IsSuccessStatusCode)
            {
                var message = await response.Content.ReadAsStringAsync();
                throw new Exception($"Failed to upload image: {message}");
            }
        }
    }
    
    public async Task UploadMovieScreenShotImage(IBrowserFile file, int movieId)
    {
        if (file != null)
        {
            // Convert the IBrowserFile to a byte array
            using var memoryStream = new MemoryStream();
            await file.OpenReadStream().CopyToAsync(memoryStream);
            var fileBytes = memoryStream.ToArray();

            // Create the new file name
            var fileName = $"movie-screenshot_{movieId}_image.jpg";
        
            // Create a ByteArrayContent from the byte array
            var fileContent = new ByteArrayContent(fileBytes);
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse(file.ContentType);
        
            // Create a multipart form content to send the file
            var multipartContent = new MultipartFormDataContent();
            multipartContent.Add(fileContent, "file", fileName);
        
            // Send the file to the server
            var response = await _httpClient.PostAsync($"api/Movie/image/screenshot", multipartContent);
        
            if (!response.IsSuccessStatusCode)
            {
                var message = await response.Content.ReadAsStringAsync();
                throw new Exception($"Failed to upload image: {message}");
            }
        }
    }
}