using AutoMapper;
using Cinemate.API.Data;
using Cinemate.API.Entities;
using Cinemate.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace Cinemate.API.Services.CategoryService;

public class MovieCategoryService : IMovieCategoryService
{
    private readonly CinemateDbContext dbContext;
    private readonly IMapper mapper;

    // Constructor injection of CinemateDbContext and IMapper
    public MovieCategoryService(CinemateDbContext dbContext, IMapper mapper)
    {
        this.dbContext = dbContext;
        this.mapper = mapper;
    }

    // Retrieves all movie categories from the database
    public async Task<IEnumerable<MovieCategoryDto>> GetAllMovieCategories()
    {
        var movieCategories = await dbContext.MovieCategories.ToListAsync();
        return mapper.Map<IEnumerable<MovieCategoryDto>>(movieCategories);
    }

    // Retrieves a single movie category by its ID from the database
    public async Task<MovieCategoryDto> GetMovieCategory(int id)
    {
        var movieCategory = await dbContext.MovieCategories.FindAsync(id);
        return mapper.Map<MovieCategoryDto>(movieCategory);
    }

    // Adds a new movie category to the database
    public async Task<MovieCategoryDto> AddMovieCategory(AddMovieCategoryDto movieCategoryDto)
    {
        var movieCategory = mapper.Map<MovieCategory>(movieCategoryDto);
        dbContext.MovieCategories.Add(movieCategory);
        await dbContext.SaveChangesAsync();
        return mapper.Map<MovieCategoryDto>(movieCategory);
    }

    // Updates an existing movie category in the database
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

    // Deletes a movie category from the database
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
