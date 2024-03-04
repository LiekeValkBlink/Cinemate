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
        CreateMap<TheaterRoom, TheaterRoomsWInfoDto>();
        CreateMap<AddTheaterRoomDto, TheaterRoom>();
        CreateMap<TheaterRoomsWInfoDto, TheaterRoom>();
        CreateMap<TheaterRoomDto, TheaterRoom>();
        CreateMap<AddSeatsDto, Seat>();
        CreateMap<SeatsDto, Seat>();
    }
}