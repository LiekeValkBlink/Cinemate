using Cinemate.Models.Dto;

namespace Cinemate.Web.Services.Contracts;

public interface IScreeningService
{
    Task<IEnumerable<ScreeningWithInfoDto>> GetAllScreenings();
    Task<ScreeningWithInfoDto> GetScreening(int id);
    Task<ScreeningWithInfoDto> AddScreening(ScreeningDto screeningDto);
    Task<ScreeningWithInfoDto> UpdateScreening(ScreeningDto screeningDto);
    Task DeleteScreening(int id);
}