using System;
using Cinemate.Models.Dto;
using Microsoft.JSInterop;
using System.Text.Json;
using System.Threading.Tasks;


// Interface defining methods for getting and setting the selected movie
public interface ISelectedMovieService
{
    // Method to asynchronously get the selected movie
    Task<MovieDtoImage> GetSelectedMovieAsync();

    // Method to asynchronously set the selected movie
    Task SetSelectedMovieAsync(MovieDtoImage movie);
}

// Service class responsible for managing the selected movie using session storage
public class SelectedMovieService : ISelectedMovieService
{
    private const string SelectedMovieKey = "SelectedMovie"; // Key for storing the selected movie in session storage
    private readonly IJSRuntime _jsRuntime; // Instance of JavaScript runtime for interacting with the browser

    // Constructor to initialize the service with an instance of IJSRuntime
    public SelectedMovieService(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    // Method to asynchronously get the selected movie from session storage
    public async Task<MovieDtoImage> GetSelectedMovieAsync()
    {
        // Invoke JavaScript function to retrieve the JSON string from session storage
        var json = await _jsRuntime.InvokeAsync<string>("sessionStorage.getItem", SelectedMovieKey);
        // Deserialize JSON string to a MovieDtoImage object or return null if JSON string is null
        return json != null ? JsonSerializer.Deserialize<MovieDtoImage>(json) : null;
    }

    // Method to asynchronously set the selected movie in session storage
    public async Task SetSelectedMovieAsync(MovieDtoImage movie)
    {
        // Serialize the movie object to JSON string
        var json = JsonSerializer.Serialize(movie);
        // Invoke JavaScript function to set the JSON string in session storage
        await _jsRuntime.InvokeVoidAsync("sessionStorage.setItem", SelectedMovieKey, json);
    }
}

