using BlazorSpinner;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Cinemate.Web;
using Cinemate.Web.Services;
using Cinemate.Web.Services.Contracts;
using Radzen;
using Syncfusion.Blazor;

// Register Syncfusion license key
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NAaF1cXmhKYVFzWmFZfVpgcV9FaFZTRGYuP1ZhSXxXdkdhUX9cc3dUQWZZWEE=");

// Create WebAssembly host builder
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app"); // Specify the root component for the application
builder.RootComponents.Add<HeadOutlet>("head::after"); // Specify the root component for the head section

// Add Blazor Bootstrap for third-party Blazor components
builder.Services.AddBlazorBootstrap();
// Add Radzen Components for third-party Blazor components
builder.Services.AddRadzenComponents();
// Add Syncfusion Blazor for third-party Blazor components
builder.Services.AddSyncfusionBlazor();

// Register HttpClient with base address for API requests
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7201/") });

// Register services used by the application
builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<ITheaterService, TheaterService>();
builder.Services.AddScoped<ITheaterRoomService, TheaterRoomService>();
builder.Services.AddScoped<IMovieCategoryService, MovieCategoryService>();
builder.Services.AddScoped<IScreeningService, ScreeningService>();
builder.Services.AddScoped<ISeatsService, SeatsService>();
builder.Services.AddScoped<IReservationService, ReservationService>();
builder.Services.AddScoped<ISelectedMovieService, SelectedMovieService>();
builder.Services.AddScoped<IUserService, UserService>();

// Add services for spinner and tooltip functionality
builder.Services.AddScoped<SpinnerService>();
builder.Services.AddScoped<TooltipService>();

// Build and run the WebAssembly application
await builder.Build().RunAsync();