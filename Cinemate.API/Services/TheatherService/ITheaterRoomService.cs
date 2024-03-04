using Cinemate.Models.Dto;

namespace Cinemate.API.Services.TheatherService;

public interface ITheaterRoomService
{
    Task<IEnumerable<TheaterRoomsWInfoDto>> GetAllTheaterRooms();
    Task<TheaterRoomsWInfoDto> GetSingleTheaterRoom(int id);
    Task<TheaterRoomsWInfoDto> AddTheaterRoom(AddTheaterRoomDto theaterRoomDto);
    Task<TheaterRoomsWInfoDto> UpdateTheaterRoom(TheaterRoomDto theaterRoomDto);
    Task DeleteTheaterRoom(int id);
}