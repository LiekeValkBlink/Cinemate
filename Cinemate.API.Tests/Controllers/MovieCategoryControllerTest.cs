using Cinemate.API.Controllers;
using Cinemate.API.Services.CategoryService;
using Cinemate.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;
using NUnit.Framework.Legacy;

namespace Cinemate.API.Tests.Controllers;

[TestFixture]
public class MovieCategoryControllerTest
{
    private Mock<IMovieCategoryService> _mockService;
    private MovieCategoryController _controller;

    [SetUp]
    public void Setup()
    {
        _mockService = new Mock<IMovieCategoryService>();
        _controller = new MovieCategoryController(_mockService.Object);
    }

    [Test]
    public async Task GetAllMovieCategories_ReturnsOkObjectResult_WithListOfMovieCategoryDto()
    {
        
        var mockCategories = new List<MovieCategoryDto>
        {
            new MovieCategoryDto { Id = 1, Name = "Action" },
            new MovieCategoryDto { Id = 2, Name = "Comedy" }
        };
        _mockService.Setup(s => s.GetAllMovieCategories()).ReturnsAsync(mockCategories);

        
        var result = await _controller.GetAllMovieCategories();

        
        Assert.That(result.Result, Is.InstanceOf<OkObjectResult>());
        var okResult = result.Result as OkObjectResult;
        Assert.That(okResult.Value, Is.InstanceOf<List<MovieCategoryDto>>());
        var categories = okResult.Value as List<MovieCategoryDto>;
        Assert.That(categories, Has.Exactly(mockCategories.Count).Items);
        CollectionAssert.AreEqual(mockCategories, categories); 
    }
}