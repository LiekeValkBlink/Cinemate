using AutoMapper;
using Cinemate.API.Data;
using Cinemate.API.Entities;
using Cinemate.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace Cinemate.API.Services.CategoryService;

public class MovieCategoryService(CinemateDbContext dbContext, IMapper mapper) : IMovieCategoryService
{
    public async Task<IEnumerable<MovieCategoryDto>> GetAllMovieCategories()
    {
        var movieCategories = await dbContext.MovieCategories.ToListAsync();
        return mapper.Map<IEnumerable<MovieCategoryDto>>(movieCategories);
    }

    public async Task<MovieCategoryDto> GetMovieCategory(int id)
    {
        var movieCategory = await dbContext.MovieCategories.FindAsync(id);
        return mapper.Map<MovieCategoryDto>(movieCategory);
    }

    public async Task<MovieCategoryDto> AddMovieCategory(MovieCategoryDto movieCategoryDto)
    {
        var movieCategory = mapper.Map<MovieCategory>(movieCategoryDto);
        dbContext.MovieCategories.Add(movieCategory);
        await dbContext.SaveChangesAsync();
        return mapper.Map<MovieCategoryDto>(movieCategory);
    }

    public async Task<MovieCategoryDto> UpdateMovieCategory(MovieCategoryDto movieCategoryDto)
    {
        var existingCategory = await dbContext.MovieCategories.FindAsync(movieCategoryDto.Id);
        if (existingCategory == null)
        {
            throw new ArgumentException("Movie category not found");
        }

        mapper.Map(movieCategoryDto, existingCategory);
        await dbContext.SaveChangesAsync();
        return mapper.Map<MovieCategoryDto>(existingCategory);
    }

    public async Task DeleteMovieCategory(int id)
    {
        var movieCategory = await dbContext.MovieCategories.FindAsync(id);
        if (movieCategory == null)
        {
            throw new ArgumentException("Movie category not found");
        }

        dbContext.MovieCategories.Remove(movieCategory);
        await dbContext.SaveChangesAsync();
    }
}