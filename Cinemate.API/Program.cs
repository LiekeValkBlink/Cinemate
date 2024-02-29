using Cinemate.API.Data;
using Cinemate.API.MappingProfiles;
using Cinemate.API.Services.CategoryService;
using Cinemate.API.Services.MovieService;
using Cinemate.API.Services.ScreeningService;
using Cinemate.API.Services.TheatherService;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CinemateDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("cinemate")));
builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<ITheaterService, TheaterService>();
builder.Services.AddScoped<ITheaterRoomService, TheaterRoomService>();
builder.Services.AddScoped<IMovieCategoryService, MovieCategoryService>();
builder.Services.AddScoped<IScreeningService, ScreeningService>();
builder.Services.AddAutoMapper(typeof(MovieProfile));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseCors(policy =>
    policy.WithOrigins("https://localhost:7156", "http://localhost:7156", "http://localhost:5221")
        .AllowAnyMethod()
        .WithHeaders(HeaderNames.ContentType)
);
app.UseHttpsRedirection();
app.MapControllers();
app.UseStaticFiles();

app.Run();
