using Cinemate.API.Data;
using Cinemate.API.Entities;
using Cinemate.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace Cinemate.API.Services.ReservationService;

public class ReservationService: IReservationService
{
    private readonly CinemateDbContext _dbContext;

    public ReservationService(CinemateDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<IEnumerable<ReservationDto>> GetAllReservations()
    {
        // Retrieve all reservations from the database
        var reservations = await _dbContext.Reservations
            .Include(r => r.Screening)
            .ThenInclude(s => s.Movie)
            .Include(r => r.Screening)
            .ThenInclude(s => s.TheaterRoom)
            .Include(r => r.User)
            .Include(r => r.Employee)
            .ToListAsync();
        
        
        // Map Reservation entities to ReservationDto
        var reservationDtos = reservations.Select(r => new ReservationDto
        {
            Id = r.Id,
            ScreeningId = r.ScreeningId,
            MovieStart = r.Screening.MovieStart,
            MovieName = r.Screening.Movie.Title,
            Paid = r.Paid,
            // Retrieve reserved seats for the reservation
            ReservedSeats = _dbContext.SeatReserved
                .Where(sr => sr.ReservationId == r.Id)
                .Select(sr => new SeatsWInfoDto
                {
                    Id = sr.SeatId,
                    Row = sr.Seat.Row,
                    Number = sr.Seat.Number,
                    TheaterRoomId = r.Screening.TheaterRoomId,
                    TheaterName = r.Screening.TheaterRoom.Name
                }).ToList(),
            TheaterRoomName = r.Screening.TheaterRoom.Name,
            // Retrieve promo codes for the reservation
            PromoCodes = _dbContext.ReservationPromoCodes
                .Where(rpc => rpc.ReservationId == r.Id)
                .Select(rpc => new PromoCodeInfoDto
                {
                    Id = rpc.PromoCode.Id,
                    Name = rpc.PromoCode.Name,
                }).ToList()
        });

        return reservationDtos;
    }

    public async Task<ReservationDto> AddReservation(AddReservationDto reservation)
    {
        try
    {
        var reservationToAdd = new Reservation
        {
            ScreeningId = reservation.ScreeningId,
            EmployeeId = reservation.EmployeeId,
            Paid = reservation.Paid,
            UserId = reservation.UserId,
            PaymentType = reservation.PaymentType,
            Price = reservation.Price
        };

        _dbContext.Reservations.Add(reservationToAdd);
        await _dbContext.SaveChangesAsync();

        foreach (var seat in reservation.SeatId)
        {
            var seatToAdd = new SeatReserved
            {
                SeatId = seat,
                ReservationId = reservationToAdd.Id,
            };
            _dbContext.SeatReserved.Add(seatToAdd);
        }

        foreach (var promoCode in reservation.PromoCode)
        {
            var PromoCodeToAdd = new ReservationPromoCodes
            {
                PromoCodeId = promoCode,
                ReservationId = reservationToAdd.Id
            };
            _dbContext.ReservationPromoCodes.Add(PromoCodeToAdd);

        }

        await _dbContext.SaveChangesAsync(); // Save changes after adding all reserved seats

        var reservationDto = GetSingleReservation(reservationToAdd.Id).Result;
        
        return reservationDto;
    }
    catch (Exception ex)
    {
        // Log the exception for troubleshooting
        Console.WriteLine($"An error occurred while adding reservation: {ex.Message}");
        throw; // Rethrow the exception to propagate it up the call stack
    }
        
    }

    public async Task<ReservationDto> GetSingleReservation(int id)
    {
        try
        {
            // Retrieve the reservation from the database by its id
            var reservation = await _dbContext.Reservations
                .Include(r => r.Screening)
                .ThenInclude(s => s.Movie)
                .Include(r => r.Screening)
                .ThenInclude(s => s.TheaterRoom)
                .Include(r => r.User)
                .Include(r => r.Employee)
                .FirstOrDefaultAsync(r => r.Id == id);

            if (reservation == null)
            {
                // If the reservation with the specified id is not found, return null or throw an exception
                return null; // or throw new Exception("Reservation not found");
            }

            // Map the reservation entity to a ReservationDto
            var reservationDto = new ReservationDto
            {
                Id = reservation.Id,
                ScreeningId = reservation.ScreeningId,
                MovieStart = reservation.Screening.MovieStart,
                MovieName = reservation.Screening.Movie.Title,
                Paid = reservation.Paid,
                ReservedSeats = await _dbContext.SeatReserved
                    .Include(sr => sr.Seat)
                    .Where(sr => sr.ReservationId == reservation.Id)
                    .Select(sr => new SeatsWInfoDto
                    {
                        Id = sr.SeatId,
                        Row = sr.Seat.Row,
                        Number = sr.Seat.Number,
                        TheaterRoomId = sr.Reservation.Screening.TheaterRoomId,
                        TheaterName = sr.Reservation.Screening.TheaterRoom.Name
                    }).ToListAsync(),
                TheaterRoomName = reservation.Screening.TheaterRoom.Name,
                PromoCodes = await _dbContext.ReservationPromoCodes
                    .Where(rpc => rpc.ReservationId == reservation.Id)
                    .Select(rpc => new PromoCodeInfoDto
                    {
                        Id = rpc.PromoCode.Id,
                        Name = rpc.PromoCode.Name,
                        // Include other properties as needed
                    }).ToListAsync()
            };

            return reservationDto;
    }
    catch (Exception ex)
    {
        // Log the exception for troubleshooting
        Console.WriteLine($"An error occurred while fetching reservation: {ex.Message}");
        throw; // Rethrow the exception to propagate it up the call stack
    }
    }



    public async Task<ReservationDto> AddSecretMovieReservation(SecretMovieDto secretMovie)
    {
        // Find all movie screenings starting at the given MovieStart datetime
        var screenings = await _dbContext.Screenings
            .Include(s => s.Movie)
            .Include(s => s.TheaterRoom)
            .Where(s => s.MovieStart == secretMovie.MovieStart)
            .ToListAsync();
    
        if (screenings == null || screenings.Count == 0)
        {
            throw new Exception("No movie screenings found for the given date and time.");
        }
    
        var minPercentage = double.MaxValue;
        Screening selectedScreening = null;
        Seat selectedSeat = null;
    
        foreach (var screening in screenings)
        {
            var theaterRoomId = screening.TheaterRoomId;
    
            // Count the total number of seats in the theater room
            var totalSeats = await _dbContext.Seats
                .Where(seat => seat.TheaterRoomId == theaterRoomId)
                .CountAsync();
    
            // Count the number of reserved seats for the screening
            var reservedSeats = await _dbContext.SeatReserved
                .Where(sr => sr.Reservation.ScreeningId == screening.Id)
                .CountAsync();
    
            // Calculate the percentage of reserved seats
            var percentageReserved = (double)reservedSeats / totalSeats * 100;
    
            // Update the selected screening if the current one has a lower percentage reserved
            if (percentageReserved < minPercentage)
            {
                minPercentage = percentageReserved;
                selectedScreening = screening;
            }
        }
    
        // Check if a screening with the lowest percentage reserved was found
        if (selectedScreening == null)
        {
            throw new Exception("No screening with the lowest percentage reserved was found.");
        }

        // Find the next available free seat in the selected screening
        selectedSeat = await _dbContext.Seats
            .Where(seat => seat.TheaterRoomId == selectedScreening.TheaterRoomId)
            .Where(seat => !_dbContext.SeatReserved.Any(sr =>
                sr.SeatId == seat.Id && sr.Reservation.ScreeningId == selectedScreening.Id))
            .FirstOrDefaultAsync();
    
            throw new NotImplementedException();
            
    }
}