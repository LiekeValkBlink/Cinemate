using Cinemate.Models.Dto;

namespace Cinemate.API.Services.ScreeningService;

public interface IScreeningService
{
    Task<IEnumerable<ScreeningWithInfoDto>> GetAllScreenings();
    Task<ScreeningWithInfoDto> GetScreening(int id);
    Task<ScreeningWithInfoDto> AddScreening(ScreeningDto screeningDto);
    Task<ScreeningWithInfoDto> UpdateScreening(ScreeningDto screeningDto);
    Task DeleteScreening(int id);
}