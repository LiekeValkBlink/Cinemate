using AutoMapper;
using Cinemate.API.Data;
using Cinemate.API.Entities;
using Cinemate.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace Cinemate.API.Services.ScreeningService;

public class ScreeningService : IScreeningService
{
    private readonly CinemateDbContext _dbContext;

    public ScreeningService(CinemateDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<ScreeningWithInfoDto> AddScreening(AddScreeningDto screeningDto)
    {
        var movieExists = await _dbContext.Movies.AnyAsync(m => m.Id == screeningDto.MovieId);
        if (!movieExists)
            throw new ArgumentException("Movie does not exist");

        var theaterRoomExists = await _dbContext.TheaterRooms.AnyAsync(tr => tr.Id == screeningDto.TheaterRoomId);
        if (!theaterRoomExists)
            throw new ArgumentException("Theater room does not exist");

        var screening = new Screening
        {
            MovieId = screeningDto.MovieId,
            TheaterRoomId = screeningDto.TheaterRoomId,
            MovieStart = screeningDto.MovieStart
        };

        _dbContext.Screenings.Add(screening);
        await _dbContext.SaveChangesAsync();

        return MapToScreeningWithInfoDto(screening);
    }

    public async Task<ScreeningWithInfoDto> UpdateScreening(ScreeningDto screeningDto)
    {
        var existingScreening = await _dbContext.Screenings.FindAsync(screeningDto.Id);
        if (existingScreening == null)
            throw new ArgumentException("Screening not found");

        var movieExists = await _dbContext.Movies.AnyAsync(m => m.Id == screeningDto.MovieId);
        if (!movieExists)
            throw new ArgumentException("Movie does not exist");

        var theaterRoomExists = await _dbContext.TheaterRooms.AnyAsync(tr => tr.Id == screeningDto.TheaterRoomId);
        if (!theaterRoomExists)
            throw new ArgumentException("Theater room does not exist");

        existingScreening.MovieId = screeningDto.MovieId;
        existingScreening.TheaterRoomId = screeningDto.TheaterRoomId;
        existingScreening.MovieStart = screeningDto.MovieStart;

        await _dbContext.SaveChangesAsync();

        return MapToScreeningWithInfoDto(existingScreening);
    }

    public async Task<IEnumerable<ScreeningWithInfoDto>> GetAllScreenings()
    {
        var screenings = await _dbContext.Screenings.ToListAsync();
        return screenings.Select(MapToScreeningWithInfoDto);
    }

    public async Task<ScreeningWithInfoDto> GetScreening(int id)
    {
        var screening = await _dbContext.Screenings.FindAsync(id);
        return screening != null ? MapToScreeningWithInfoDto(screening) : null;
    }

    public async Task DeleteScreening(int id)
    {
        var screening = await _dbContext.Screenings.FindAsync(id);
        if (screening != null)
        {
            _dbContext.Screenings.Remove(screening);
            await _dbContext.SaveChangesAsync();
        }
    }

    private ScreeningWithInfoDto MapToScreeningWithInfoDto(Screening screening)
    {
        return new ScreeningWithInfoDto
        {
            Id = screening.Id,
            MovieId = screening.MovieId,
            MovieName = _dbContext.Movies.FirstOrDefault(m => m.Id == screening.MovieId)?.Title,
            TheaterRoomId = screening.TheaterRoomId,
            TheaterName = _dbContext.TheaterRooms.FirstOrDefault(tr => tr.Id == screening.TheaterRoomId)?.Name,
            MovieStart = screening.MovieStart
        };
    }
}