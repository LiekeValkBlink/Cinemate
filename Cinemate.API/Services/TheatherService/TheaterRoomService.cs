using AutoMapper;
using Cinemate.API.Data;
using Cinemate.API.Entities;
using Cinemate.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace Cinemate.API.Services.TheatherService;

public class TheaterRoomService: ITheaterRoomService
{
    private readonly CinemateDbContext _dbContext;
    private readonly IMapper _mapper;
    private readonly ITheaterService _theaterService;

    public TheaterRoomService(CinemateDbContext dbContext, IMapper mapper, ITheaterService theaterService)
    {
        _dbContext = dbContext;
        _mapper = mapper;
        _theaterService = theaterService;
    }
    public async Task<IEnumerable<TheaterRoomsDto>> GetAllTheaterRooms()
    {
        var theaterRooms = await _dbContext.TheatherRooms
            .Include(tr => tr.Theater)
            .ToListAsync();
        
        return _mapper.Map<IEnumerable<TheaterRoomsDto>>(theaterRooms);
    }
    
    public async Task<TheaterRoomsDto> GetSingleTheaterRoom(int id)
    {
        var theaterRoom = await _dbContext.TheatherRooms
            .Include(tr => tr.Theater)
            .FirstOrDefaultAsync(tr => tr.Id == id);

        return _mapper.Map<TheaterRoomsDto>(theaterRoom);
    }

    public async Task<TheaterRoomsDto> AddTheaterRoom(AddOrUpdateTheaterRoomDto theaterRoomDto)
    {
        
        
        var theaterRoom = _mapper.Map<TheaterRoom>(theaterRoomDto);
        _dbContext.TheatherRooms.Add(theaterRoom);
        await _dbContext.SaveChangesAsync();
        
        return _mapper.Map<TheaterRoomsDto>(theaterRoom);
    }

    public async Task<TheaterRoomsDto> UpdateTheaterRoom(AddOrUpdateTheaterRoomDto theaterRoomDto)
    {
        var theaterRoom = await _dbContext.TheatherRooms
            .Include(tr => tr.Theater) // Include the related theater
            .FirstOrDefaultAsync(tr => tr.Id == theaterRoomDto.Id);
        if (theaterRoom == null)
        {
            throw new ArgumentException("Theater room not found");
        }

        _mapper.Map(theaterRoomDto, theaterRoom);
        await _dbContext.SaveChangesAsync();
        
        return _mapper.Map<TheaterRoomsDto>(theaterRoom);
    }

    public async Task DeleteTheaterRoom(int id)
    {
        var theaterRoom = await _dbContext.TheatherRooms.FindAsync(id);
        if (theaterRoom == null)
        {
            throw new ArgumentException("Theater room not found");
        }

        _dbContext.TheatherRooms.Remove(theaterRoom);
        await _dbContext.SaveChangesAsync();
    }


}