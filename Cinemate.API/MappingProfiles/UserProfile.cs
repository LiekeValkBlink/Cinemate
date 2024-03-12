using AutoMapper;
using Cinemate.API.Entities;
using Cinemate.Models.Dto;

namespace Cinemate.API.MappingProfiles;

public class UserProfile: Profile
{
    public UserProfile()
    {
        CreateMap<UserDto, User>();
        CreateMap<User, UserDto>();
        CreateMap<AddUserDto, User>();

    }
}