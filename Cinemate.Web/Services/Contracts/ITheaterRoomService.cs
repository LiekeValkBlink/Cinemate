using Cinemate.Models.Dto;

namespace Cinemate.Web.Services.Contracts;

public interface ITheaterRoomService
{
    Task<IEnumerable<TheaterRoomsWInfoDto>> GetAllTheaterRooms();
    Task<TheaterRoomsWInfoDto> GetSingleTheaterRoom(int id);
    Task<TheaterRoomsWInfoDto> AddTheaterRoom(AddTheaterRoomDto theaterRoomDto);
    Task<TheaterRoomsWInfoDto> UpdateTheaterRoom(TheaterRoomDto theaterRoomDto);
    Task DeleteTheaterRoom(int id);
}