using AutoMapper;
using Cinemate.API.Entities;
using Cinemate.Models.Dto;

namespace Cinemate.API.MappingProfiles;

public class MovieProfile: Profile
{
    public MovieProfile()
    {
        CreateMap<Movie, MovieDto>();
        CreateMap<MovieDto, Movie>();
        CreateMap<AddOrUpdateMovieDto, Movie>();
        CreateMap<MovieCategoryDto, MovieCategory>();
        CreateMap<AddMovieCategoryDto, MovieCategory>();
        CreateMap<MovieCategory, MovieCategoryDto>();
    }
}