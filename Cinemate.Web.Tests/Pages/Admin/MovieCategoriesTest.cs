using Bunit;
using Cinemate.Models.Dto;
using Cinemate.Web.Services.Contracts;
using Cinemate.Web.Pages.Admin;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorBootstrap;
using NUnit.Framework;
using TestContext = Bunit.TestContext;

namespace Cinemate.Web.Tests.Pages.Admin;

[TestFixture]
public class MovieCategoriesTest
{
    [Test]
    public async Task MovieCategories_InitializesAndDisplaysCategories()
    {
        var mockMovieCategoryService = new Mock<IMovieCategoryService>();
        var fakeCategories = new List<MovieCategoryDto>
        {
            new MovieCategoryDto { Id = 1, Name = "Action" },
            new MovieCategoryDto { Id = 2, Name = "Drama" }
        };
        mockMovieCategoryService.Setup(service => service.GetAllMovieCategories()).ReturnsAsync(fakeCategories);

        var mockPreloadService = new Mock<PreloadService>();
        var mockIdGenerator = new Mock<IIdGenerator>();
        mockIdGenerator.Setup(x => x.Generate()).Returns("some-unique-id");
        var mockModalService = new Mock<ModalService>(); 

        using var ctx = new TestContext();
        ctx.Services.AddScoped(_ => mockMovieCategoryService.Object);
        ctx.Services.AddScoped(_ => mockPreloadService.Object);
        ctx.Services.AddScoped(_ => mockIdGenerator.Object);
        ctx.Services.AddScoped(_ => mockModalService.Object); 

        var cut = ctx.RenderComponent<MovieCategories>();

        cut.WaitForState(() => cut.Markup.Contains("Action") && cut.Markup.Contains("Drama"));
        Assert.That(cut.FindAll("tr").Count, Is.EqualTo(fakeCategories.Count));
    }
    
    public interface IIdGenerator
    {
        string Generate();
    }

}