using System.Globalization;
using BlazorSpinner;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Cinemate.Web;
using Cinemate.Web.Services;
using Cinemate.Web.Services.Contracts;
using Microsoft.Extensions.Localization;
using Radzen;
using Syncfusion.Blazor;

// Registreer Syncfusion licentie
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Jouw Syncfusion Licentiesleutel Hier");

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Voeg services toe
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
builder.Services.AddBlazorBootstrap();
builder.Services.AddRadzenComponents();
builder.Services.AddSyncfusionBlazor();

// HTTP Client voor API calls
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Voeg je eigen services toe
builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<ITheaterService, TheaterService>();
builder.Services.AddScoped<ITheaterRoomService, TheaterRoomService>();
builder.Services.AddScoped<IMovieCategoryService, MovieCategoryService>();
builder.Services.AddScoped<IScreeningService, ScreeningService>();
builder.Services.AddScoped<ISeatsService, SeatsService>();
builder.Services.AddScoped<IReservationService, ReservationService>();
builder.Services.AddScoped<ISelectedMovieService, SelectedMovieService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<SpinnerService>();

// Stel de ondersteunde culturen in
var supportedCultures = new[] { "en-US", "nl-NL" };
var appCulture = new CultureInfo("nl-NL");

CultureInfo.DefaultThreadCurrentCulture = appCulture;
CultureInfo.DefaultThreadCurrentUICulture = appCulture;

await builder.Build().RunAsync();