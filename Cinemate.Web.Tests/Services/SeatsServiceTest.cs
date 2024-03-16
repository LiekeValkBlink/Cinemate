using Cinemate.Models.Dto;
using Cinemate.Web.Services;
using Moq;
using Moq.Protected;
using NUnit.Framework;
using System;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Cinemate.Web.Tests.Services;

[TestFixture]
public class SeatsServiceTest
{
    private Mock<HttpMessageHandler> _mockHandler;
    private SeatsService _service;

    [SetUp]
    public void SetUp()
    {
        _mockHandler = new Mock<HttpMessageHandler>();
        var client = new HttpClient(_mockHandler.Object)
        {
            BaseAddress = new Uri("http://test.com/")
        };

        _service = new SeatsService(client);
    }

   
    [Test]
    public async Task AddSeat_ReturnsAddedSeat()
    {
        var fakeSeatToAdd = new AddSeatsDto { /* properties ter test */ };
        var fakeAddedSeat = new SeatsWInfoDto { /* properties ter test */ };
        var fakeResponse = new HttpResponseMessage(HttpStatusCode.Created)
        {
            Content = new StringContent(JsonSerializer.Serialize(fakeAddedSeat), System.Text.Encoding.UTF8, "application/json")
        };

        _mockHandler.Protected().Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(fakeResponse);

        var result = await _service.AddSeat(fakeSeatToAdd);
        
        Assert.That(result, Is.Not.Null);
    }
}