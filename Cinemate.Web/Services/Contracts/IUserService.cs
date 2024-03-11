using Cinemate.Models.Dto;

namespace Cinemate.Web.Services.Contracts;

public interface IUserService
{
    Task<IEnumerable<UserDto>> GetAllUsers();
    Task<UserDto> GetUserById(int id);
    Task<UserDto> CreateUser(AddUserDto user);
    Task<UserDto> UpdateUser(int id, UserDto user);
    Task DeleteUser(int id);
}