using Cinemate.Models.Dto;
using Cinemate.Web.Services;
using Moq;
using Moq.Protected;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Cinemate.Web.Tests.Services;

[TestFixture]
public class MovieCategoryServiceTest
{
    private Mock<HttpMessageHandler> _mockHandler;
    private MovieCategoryService _service;

    [SetUp]
    public void SetUp()
    {
        _mockHandler = new Mock<HttpMessageHandler>();
        var client = new HttpClient(_mockHandler.Object)
        {
            BaseAddress = new Uri("http://test.com/")
        };

        _service = new MovieCategoryService(client);
    }

    [Test]
    public async Task GetAllMovieCategories_ReturnsAllCategories()
    {
        var fakeCategories = new List<MovieCategoryDto>
        {
            new MovieCategoryDto { /* properties ter test */ },
            new MovieCategoryDto { /* properties ter test */ }
        };
        var fakeResponse = new HttpResponseMessage(HttpStatusCode.OK)
        {
            Content = new StringContent(JsonSerializer.Serialize(fakeCategories), System.Text.Encoding.UTF8, "application/json")
        };

        _mockHandler.Protected().Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(fakeResponse);

        var result = await _service.GetAllMovieCategories();

        for (int i = 0; i < fakeCategories.Count; i++)
        {
            Assert.That(result.ElementAt(i).Id, Is.EqualTo(fakeCategories[i].Id));
            Assert.That(result.ElementAt(i).Name, Is.EqualTo(fakeCategories[i].Name));
        }

    }

    [Test]
    public async Task GetMovieCategory_ReturnsCategory()
    {
        var fakeCategory = new MovieCategoryDto { /* properties ter test */ };
        var fakeResponse = new HttpResponseMessage(HttpStatusCode.OK)
        {
            Content = new StringContent(JsonSerializer.Serialize(fakeCategory), System.Text.Encoding.UTF8, "application/json")
        };

        _mockHandler.Protected().Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(fakeResponse);

        var result = await _service.GetMovieCategory(1);

        Assert.That(result, Is.Not.Null);
        Assert.That(result, Is.EqualTo(fakeCategory).Using(new MovieCategoryDtoComparer()));
    }
    
    public class MovieCategoryDtoComparer : IEqualityComparer<MovieCategoryDto>
    {
        public bool Equals(MovieCategoryDto x, MovieCategoryDto y)
        {
            return x.Id == y.Id; 
        }

        public int GetHashCode(MovieCategoryDto obj)
        {
            return obj.Id.GetHashCode();
        }
    }



}