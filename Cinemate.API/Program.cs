using Cinemate.API.Data;
using Cinemate.API.MappingProfiles;
using Cinemate.API.Services.MovieService;
using Microsoft.EntityFrameworkCore;
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
builder.Services.AddAutoMapper(typeof(MovieProfile));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseCors(policy =>
    policy.WithOrigins("https://localhost:7271", "http://localhost:7271")
        .AllowAnyMethod()
        .WithHeaders(HeaderNames.ContentType)
);
app.UseHttpsRedirection();
app.MapControllers();


app.Run();
