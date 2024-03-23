using Cinemate.API.Controllers;
using Cinemate.API.Services.ScreeningService;
using Cinemate.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinemate.API.Tests.Controllers;

[TestFixture]
public class ScreeningControllerTest
{
    private Mock<IScreeningService> _mockScreeningService;
    private ScreeningController _controller;

    [SetUp]
    public void SetUp()
    {
        _mockScreeningService = new Mock<IScreeningService>();
        _controller = new ScreeningController(_mockScreeningService.Object);
    }

    [Test]
    public async Task GetAllScreenings_ReturnsAllScreenings()
    {
        var fakeScreenings = new List<ScreeningWithInfoDto>
        {
            new ScreeningWithInfoDto { /* properties ter test */ },
            new ScreeningWithInfoDto { /* properties ter test */ }
        };
        _mockScreeningService.Setup(service => service.GetAllScreenings())
            .ReturnsAsync(fakeScreenings);
        
        var result = await _controller.GetAllScreenings();
        
        Assert.That(result, Is.Not.Null);
        var okResult = result.Result as OkObjectResult;
        Assert.That(okResult, Is.Not.Null);
        Assert.That(okResult.StatusCode, Is.EqualTo(200));
        var screeningsResult = okResult.Value as IEnumerable<ScreeningWithInfoDto>;
        Assert.That(screeningsResult, Is.Not.Null);
        Assert.That(screeningsResult, Has.Count.EqualTo(fakeScreenings.Count));
    }
}