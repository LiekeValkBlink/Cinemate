using Cinemate.API.Controllers;
using Cinemate.API.Services.TheatherService;
using Cinemate.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinemate.API.Tests.Controllers;

[TestFixture]
public class TheaterControllerTest
{
    private Mock<ITheaterService> _mockTheaterService;
    private TheaterController _controller;

    [SetUp]
    public void SetUp()
    {
        _mockTheaterService = new Mock<ITheaterService>();
        _controller = new TheaterController(_mockTheaterService.Object);
    }

    [Test]
    public async Task GetAllTheaters_ReturnsAllTheaters()
    {
        var fakeTheaters = new List<TheaterDto>
        {
            new TheaterDto { /* properties ter test*/ },
            new TheaterDto { /* properties ter test */ }
        };
        _mockTheaterService.Setup(service => service.GetAllTheaters()).ReturnsAsync(fakeTheaters);

        var result = await _controller.GetAllTheaters();

        Assert.That(result.Result, Is.InstanceOf<OkObjectResult>());
        var okResult = result.Result as OkObjectResult;
        Assert.That(okResult.Value, Is.EqualTo(fakeTheaters));
    }

    [Test]
    public async Task GetSingleTheater_ReturnsTheater_WhenFound()
    {
        var fakeTheater = new TheaterDto { /* properties ter test */ };
        _mockTheaterService.Setup(service => service.GetSingleTheater(It.IsAny<int>())).ReturnsAsync(fakeTheater);

        var result = await _controller.GetSingleTheater(1);

        Assert.That(result.Result, Is.InstanceOf<OkObjectResult>());
    }

    [Test]
    public async Task GetSingleTheater_ReturnsNotFound_WhenNotExists()
    {
        _mockTheaterService.Setup(service => service.GetSingleTheater(It.IsAny<int>())).ReturnsAsync((TheaterDto)null);

        var result = await _controller.GetSingleTheater(1);

        Assert.That(result.Result, Is.InstanceOf<NotFoundResult>());
    }
    
    [Test]
    public async Task AddTheater_ReturnsCreatedAtAction_WhenAdded()
    {
        var fakeTheater = new TheaterDto { /* properties ter test */ };
        _mockTheaterService.Setup(service => service.AddTheater(It.IsAny<TheaterDto>())).ReturnsAsync(fakeTheater);

        var result = await _controller.AddTheater(new TheaterDto());

        Assert.That(result.Result, Is.InstanceOf<CreatedAtActionResult>());
    }
    
    [Test]
    public async Task UpdateTheater_ReturnsOk_WhenUpdated()
    {
        var fakeTheater = new TheaterDto { Id = 1 /* properties ter test */ };
        _mockTheaterService.Setup(service => service.UpdateTheater(It.IsAny<TheaterDto>())).ReturnsAsync(fakeTheater);

        var result = await _controller.UpdateTheater(1, fakeTheater);

        Assert.That(result.Result, Is.InstanceOf<OkObjectResult>());
    }

    [Test]
    public async Task UpdateTheater_ReturnsBadRequest_WhenIdMismatch()
    {
        var result = await _controller.UpdateTheater(2, new TheaterDto { Id = 1 });

        Assert.That(result.Result, Is.InstanceOf<BadRequestObjectResult>());
    }

    [Test]
    public async Task DeleteTheater_ReturnsNoContent_WhenDeleted()
    {
        _mockTheaterService.Setup(service => service.DeleteTheater(It.IsAny<int>())).Returns(Task.CompletedTask);

        var result = await _controller.DeleteTheater(1);

        Assert.That(result, Is.InstanceOf<NoContentResult>());
    }

    [Test]
    public async Task DeleteTheater_ReturnsNotFound_WhenNotExists()
    {
        _mockTheaterService.Setup(service => service.DeleteTheater(It.IsAny<int>())).Throws(new ArgumentException());

        var result = await _controller.DeleteTheater(1);

        Assert.That(result, Is.InstanceOf<NotFoundObjectResult>());
    }


}