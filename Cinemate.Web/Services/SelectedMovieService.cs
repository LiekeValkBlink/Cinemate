using System;
using Cinemate.Models.Dto;
using Microsoft.JSInterop;
using System.Text.Json;
using System.Threading.Tasks;


public interface ISelectedMovieService
{
    Task<MovieDtoImage> GetSelectedMovieAsync();
    Task SetSelectedMovieAsync(MovieDtoImage movie);
}

public class SelectedMovieService : ISelectedMovieService
{
    private const string SelectedMovieKey = "SelectedMovie";
    private readonly IJSRuntime _jsRuntime;

    public SelectedMovieService(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    public async Task<MovieDtoImage> GetSelectedMovieAsync()
    {
        var json = await _jsRuntime.InvokeAsync<string>("sessionStorage.getItem", SelectedMovieKey);
        return json != null ? JsonSerializer.Deserialize<MovieDtoImage>(json) : null;
    }

    public async Task SetSelectedMovieAsync(MovieDtoImage movie)
    {
        var json = JsonSerializer.Serialize(movie);
        await _jsRuntime.InvokeVoidAsync("sessionStorage.setItem", SelectedMovieKey, json);
    }
}

