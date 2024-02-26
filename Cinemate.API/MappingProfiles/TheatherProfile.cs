using AutoMapper;
using Cinemate.API.Entities;
using Cinemate.Models.Dto;

namespace Cinemate.API.MappingProfiles;

public class TheatherProfile: Profile
{
    public TheatherProfile()
    {
        CreateMap<TheaterDto, Theater>();
        CreateMap<Theater, TheaterDto>();
        CreateMap<TheaterRoom, TheaterRoomsDto>();
        CreateMap<TheaterRoomsDto, TheaterRoom>();
        CreateMap<AddOrUpdateTheaterRoomDto, TheaterRoom>();

    }
}