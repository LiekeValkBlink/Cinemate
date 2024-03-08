using AutoMapper;
using Cinemate.API.Data;
using Cinemate.API.Entities;
using Cinemate.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace Cinemate.API.Services.TheatherService;

public class SeatsService: ISeatsService
{
    private readonly CinemateDbContext _dbContext;
    private readonly IMapper _mapper;

    public SeatsService(CinemateDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<IEnumerable<SeatsWInfoDto>> GetAllSeats()
    {
        var seats = await _dbContext.Seats.ToListAsync();
        var seatsWithInfo = seats.Select(s =>
        {
            var theaterRoom = _dbContext.TheaterRooms.FirstOrDefault(tr => tr.Id == s.TheaterRoomId);
            return new SeatsWInfoDto
            {
                Id = s.Id,
                Row = s.Row,
                Number = s.Number,
                TheaterRoomId = s.TheaterRoomId,
                TheaterName = theaterRoom != null ? theaterRoom.Name : "Unknown" // Or handle this case as you need
            };
        });
        return seatsWithInfo;
    }

    public async Task<IEnumerable<SeatsWInfoDto>> GetSeatsByTheaterRoomId(int theaterRoomId)
    {
        var seats = await _dbContext.Seats
            .Where(s => s.TheaterRoomId == theaterRoomId)
            .ToListAsync();

        var seatsWithInfo = new List<SeatsWInfoDto>();

        foreach (var seat in seats)
        {
            // Fetch additional information from the TheaterRoom table
            var theaterRoom = await _dbContext.TheaterRooms
                .FirstOrDefaultAsync(tr => tr.Id == seat.TheaterRoomId);

            // Create SeatsWInfoDto object manually
            var seatWithInfo = new SeatsWInfoDto
            {
                Id = seat.Id,
                Row = seat.Row,
                Number = seat.Number,
                TheaterRoomId = seat.TheaterRoomId,
                TheaterName = theaterRoom.Name
            };

            seatsWithInfo.Add(seatWithInfo);
        }

        return seatsWithInfo;
    }

    public async Task<IEnumerable<ReservedSeatDto>> GetReservedSeatsByScreeningId(int screeningId)
    {
        try
        {
            var reservedSeats = await _dbContext.SeatReserved
                .Include(sr => sr.Seat)
                .ThenInclude(seat => seat.TheaterRoom)
                .Where(sr => sr.Reservation.ScreeningId == screeningId)
                .ToListAsync();

            var reservedSeatsDto = reservedSeats.Select(sr => new ReservedSeatDto
            {
                Id = sr.SeatId,
                Row = sr.Seat.Row,
                Number = sr.Seat.Number,
                TheaterRoomId = sr.Seat.TheaterRoomId,
            }).ToList();

            return reservedSeatsDto;
        }
        catch (Exception ex)
        {
            throw new Exception("Error retrieving reserved seats: " + ex.Message);
        }
    }


    public async Task<SeatsWInfoDto> GetSeatById(int id)
    {
        var seat = await _dbContext.Seats.FindAsync(id);
        var theaterRoom = _dbContext.TheaterRooms.FirstOrDefault(tr => tr.Id == seat.TheaterRoomId);
        return new SeatsWInfoDto
        {
            Id = seat.Id,
            Row = seat.Row,
            Number = seat.Number,
            TheaterRoomId = seat.TheaterRoomId,
            TheaterName = theaterRoom.Name
        };
    }

    public async Task<SeatsWInfoDto> AddSeat(AddSeatsDto seat)
    {
        var newSeat = _mapper.Map<Seat>(seat);
        _dbContext.Seats.Add(newSeat);
        await _dbContext.SaveChangesAsync();

        // Fetch additional information from the TheaterRoom table
        var theaterRoom = await _dbContext.TheaterRooms
            .FirstOrDefaultAsync(tr => tr.Id == seat.TheaterRoomId);

        // Create SeatsWInfoDto object manually
        var seatWithInfo = new SeatsWInfoDto
        {
            Id = newSeat.Id,
            Row = newSeat.Row,
            Number = newSeat.Number,
            TheaterRoomId = newSeat.TheaterRoomId,
            TheaterName = theaterRoom.Name
        };

        return seatWithInfo;
    }

    public async Task<SeatsWInfoDto> UpdateSeat(int id, SeatsDto seat)
    {
        var existingSeat = await _dbContext.Seats.FindAsync(id);
        if (existingSeat == null)
        {
            return null; 
        }

        // Map properties from SeatsDto to existing Seat entity
        _mapper.Map(seat, existingSeat);
        await _dbContext.SaveChangesAsync();

        // Fetch additional information from the TheaterRoom table
        var theaterRoom = await _dbContext.TheaterRooms
            .FirstOrDefaultAsync(tr => tr.Id == existingSeat.TheaterRoomId);

        // Create SeatsWInfoDto object manually
        var seatWithInfo = new SeatsWInfoDto
        {
            Id = existingSeat.Id,
            Row = existingSeat.Row,
            Number = existingSeat.Number,
            TheaterRoomId = existingSeat.TheaterRoomId,
            TheaterName = theaterRoom.Name
        };

        return seatWithInfo;
    }

    public async Task DeleteSeat(int id)
    {
        var seatToDelete = await _dbContext.Seats.FindAsync(id);
        if (seatToDelete != null)
        {
            _dbContext.Seats.Remove(seatToDelete);
            await _dbContext.SaveChangesAsync();
        }
    }
}