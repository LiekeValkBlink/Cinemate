using AutoMapper;
using Cinemate.API.Data;
using Cinemate.API.Entities;
using Cinemate.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace Cinemate.API.Services.TheatherService;

public class TheaterService: ITheaterService
{
    private readonly CinemateDbContext _dbContext;
    private readonly IMapper _mapper;

    public TheaterService(CinemateDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }
    
    public async Task<IEnumerable<TheaterDto>> GetAllTheaters()
    {
        var theaters = await _dbContext.Theathers.ToListAsync();
        return _mapper.Map<IEnumerable<TheaterDto>>(theaters);    
    }

    public async Task<TheaterDto?> GetSingleTheater(int id)
    {
        var theater = await _dbContext.Theathers.FindAsync(id);
        return _mapper.Map<TheaterDto>(theater);
    }

    public async Task<TheaterDto> AddTheater(TheaterDto theaterDto)
    {
        try
        {
            var theater = _mapper.Map<Theater>(theaterDto);
            _dbContext.Theathers.Add(theater);
            await _dbContext.SaveChangesAsync();
            return _mapper.Map<TheaterDto>(theater);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<TheaterDto> UpdateTheater(TheaterDto theaterDto)
    {
        var theater = await _dbContext.Theathers.FindAsync(theaterDto.Id);
        if (theater == null)
        {
            throw new ArgumentException("Theater not found");
        }

        _mapper.Map(theaterDto, theater);
        await _dbContext.SaveChangesAsync();
        return _mapper.Map<TheaterDto>(theater);
    }

    public async Task DeleteTheater(int id)
    {
        var theater = await _dbContext.Theathers.FindAsync(id);
        if (theater == null)
        {
            throw new ArgumentException("Theater not found");
        }

        _dbContext.Theathers.Remove(theater);
        await _dbContext.SaveChangesAsync();
    }
}