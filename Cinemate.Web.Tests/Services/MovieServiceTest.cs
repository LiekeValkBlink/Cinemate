using Cinemate.Models.Dto;
using Cinemate.Web.Services;
using Moq;
using Moq.Protected;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework.Legacy;

namespace Cinemate.Web.Tests.Services;

[TestFixture]
public class MovieServiceTest
{
    private Mock<HttpMessageHandler> _mockHandler;
    private MovieService _service;

    [SetUp]
    public void SetUp()
    {
        _mockHandler = new Mock<HttpMessageHandler>();
        var client = new HttpClient(_mockHandler.Object)
        {
            BaseAddress = new Uri("http://test.com/")
        };

        _service = new MovieService(client);
    }

    [Test]
    public async Task GetMovies_ReturnsMovies()
    {
        var fakeMovies = new List<MovieWithCategoryDto>
        {
            new MovieWithCategoryDto { /* properties ter test */ },
            new MovieWithCategoryDto { /* properties ter test */ }
        };
        var fakeResponse = new HttpResponseMessage(HttpStatusCode.OK)
        {
            Content = new StringContent(JsonSerializer.Serialize(fakeMovies), System.Text.Encoding.UTF8, "application/json")
        };

        _mockHandler.Protected().Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(fakeResponse);

        var result = await _service.GetMovies();

        Assert.That(result, Is.Not.Empty);
        CollectionAssert.AreEquivalent(fakeMovies, result);
        
    }
    
    [Test]
    public async Task GetMovie_ReturnsMovie_WhenFound()
    {
        var fakeMovie = new MovieWithCategoryDto { /* properties ter test */ };
        var fakeResponse = new HttpResponseMessage(HttpStatusCode.OK)
        {
            Content = new StringContent(JsonSerializer.Serialize(fakeMovie), System.Text.Encoding.UTF8, "application/json")
        };

        _mockHandler.Protected().Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(fakeResponse);

        var result = await _service.GetMovie(1);

        Assert.That(result, Is.Not.Null);
    }
}