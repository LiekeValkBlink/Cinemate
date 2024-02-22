using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Cinemate.Web;
using Cinemate.Web.Services;
using Cinemate.Web.Services.Contracts;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddBlazorBootstrap();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7201/") });
builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<ITheaterService, TheaterService>();
builder.Services.AddScoped<ITheaterRoomService, TheaterRoomService>();
builder.Services.AddScoped<IMovieCategoryService, MovieCategoryService>();

await builder.Build().RunAsync();