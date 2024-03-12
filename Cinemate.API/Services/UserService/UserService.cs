using AutoMapper;
using Cinemate.API.Data;
using Cinemate.API.Entities;
using Cinemate.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace Cinemate.API.Services.UserService;

public class UserService: IUserService
{
    private readonly CinemateDbContext _dbContext;
    private readonly IMapper _mapper;

    public UserService(CinemateDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<IEnumerable<UserDto>> GetAllUsers()
    {
        var users = await _dbContext.Users.ToListAsync();
        return _mapper.Map<IEnumerable<UserDto>>(users);
    }

    public async Task<UserDto> GetUserById(int id)
    {
        var user = await _dbContext.Users.FindAsync(id);
        return _mapper.Map<UserDto>(user);
    }
    
    public async Task<UserDto> CreateUser(AddUserDto userDto)
    {
        var user = _mapper.Map<User>(userDto);

        _dbContext.Users.Add(user);
        await _dbContext.SaveChangesAsync();

        return _mapper.Map<UserDto>(user);
    }

    public async Task<UserDto> UpdateUser(int id, UserDto userDto)
    {
        var existingUser = await _dbContext.Users.FindAsync(id);
        if (existingUser == null)
        {
            return null;
        }

        _mapper.Map(userDto, existingUser);

        await _dbContext.SaveChangesAsync();

        return _mapper.Map<UserDto>(existingUser);
    }

    public async Task DeleteUser(int id)
    {
        var user = await _dbContext.Users.FindAsync(id);

        _dbContext.Users.Remove(user);
        await _dbContext.SaveChangesAsync();

    }
}