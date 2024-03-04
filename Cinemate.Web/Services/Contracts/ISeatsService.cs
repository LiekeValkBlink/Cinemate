using Cinemate.Models.Dto;

namespace Cinemate.Web.Services.Contracts;

public interface ISeatsService
{
    Task<IEnumerable<SeatsWInfoDto>> GetAllSeats();
    Task<IEnumerable<SeatsWInfoDto>> GetSeatsByTheaterRoomId(int theaterRoomId);
    Task<SeatsWInfoDto> GetSeatById(int id);
    Task<SeatsWInfoDto> AddSeat(AddSeatsDto seat);
    Task<SeatsWInfoDto> UpdateSeat(int id, SeatsDto seat);
    Task DeleteSeat(int id);
}