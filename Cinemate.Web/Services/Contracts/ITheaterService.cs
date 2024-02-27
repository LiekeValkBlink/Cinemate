using Cinemate.Models.Dto;

namespace Cinemate.Web.Services.Contracts;

public interface ITheaterService
{
    Task<IEnumerable<TheaterDto>> GetAllTheaters();
    Task<TheaterDto> GetSingleTheater(int id);
    Task<TheaterDto> AddTheater(TheaterDto theaterDto);
    Task<TheaterDto> UpdateTheater(TheaterDto theaterDto);
    Task DeleteTheater(int id);
}