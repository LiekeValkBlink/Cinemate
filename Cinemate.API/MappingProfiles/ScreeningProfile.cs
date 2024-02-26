using AutoMapper;
using Cinemate.API.Entities;
using Cinemate.Models.Dto;

namespace Cinemate.API.MappingProfiles;

public class ScreeningProfile: Profile
{
    public ScreeningProfile()
    {
        CreateMap<ScreeningDto, Screening>();
        CreateMap<Screening, ScreeningDto>();
    }
}