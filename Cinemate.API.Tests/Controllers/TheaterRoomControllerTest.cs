using System;
using Cinemate.API.Controllers;
using Cinemate.API.Services.TheatherService;
using Cinemate.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinemate.API.Tests.Controllers;

[TestFixture]
public class TheaterRoomControllerTest
{
    private Mock<ITheaterRoomService> _mockTheaterRoomService;
    private Mock<ITheaterService> _mockTheaterService;
    private TheaterRoomController _controller;

    [SetUp]
    public void SetUp()
    {
        _mockTheaterRoomService = new Mock<ITheaterRoomService>();
        _mockTheaterService = new Mock<ITheaterService>();
        _controller = new TheaterRoomController(_mockTheaterRoomService.Object, _mockTheaterService.Object);
    }

    [Test]
    public async Task GetAllTheaterRooms_ReturnsAllTheaterRooms()
    {
        var fakeTheaterRooms = new List<TheaterRoomsWInfoDto>
        {
            new TheaterRoomsWInfoDto { /* properties ter test */ },
            new TheaterRoomsWInfoDto { /* properties ter test */ }
        };
        _mockTheaterRoomService.Setup(service => service.GetAllTheaterRooms()).ReturnsAsync(fakeTheaterRooms);

        var result = await _controller.GetAllTheaterRooms();

        Assert.That(result.Result, Is.InstanceOf<OkObjectResult>());
        var okResult = result.Result as OkObjectResult;
        Assert.That(okResult.Value, Is.EqualTo(fakeTheaterRooms));
    }
    
    [Test]
    public async Task GetSingleTheaterRoom_ReturnsTheaterRoom_WhenFound()
    {
        var fakeTheaterRoom = new TheaterRoomsWInfoDto { /* properties ter test */ };
        _mockTheaterRoomService.Setup(service => service.GetSingleTheaterRoom(It.IsAny<int>())).ReturnsAsync(fakeTheaterRoom);

        var result = await _controller.GetSingleTheaterRoom(1);

        Assert.That(result.Result, Is.InstanceOf<OkObjectResult>());
    }

    [Test]
    public async Task GetSingleTheaterRoom_ReturnsNotFound_WhenNotExists()
    {
        _mockTheaterRoomService.Setup(service => service.GetSingleTheaterRoom(It.IsAny<int>())).ReturnsAsync((TheaterRoomsWInfoDto)null);

        var result = await _controller.GetSingleTheaterRoom(1);

        Assert.That(result.Result, Is.InstanceOf<NotFoundResult>());
    }
    
    [Test]
    public async Task AddTheaterRoom_ReturnsCreatedAtAction_WhenTheaterExists()
    {
        var fakeTheaterRoom = new TheaterRoomsWInfoDto { Id = 1 /* properties ter test */ };
        _mockTheaterService.Setup(service => service.GetSingleTheater(It.IsAny<int>())).ReturnsAsync(new TheaterDto());
        _mockTheaterRoomService.Setup(service => service.AddTheaterRoom(It.IsAny<AddTheaterRoomDto>())).ReturnsAsync(fakeTheaterRoom);

        var result = await _controller.AddTheaterRoom(new AddTheaterRoomDto { TheaterId = 1 });

        Assert.That(result.Result, Is.InstanceOf<CreatedAtActionResult>());
    }

    [Test]
    public void AddTheaterRoom_ThrowsArgumentException_WhenTheaterDoesNotExist()
    {
        _mockTheaterService.Setup(service => service.GetSingleTheater(It.IsAny<int>())).ReturnsAsync((TheaterDto)null);

        Assert.ThrowsAsync<ArgumentException>(async () => await _controller.AddTheaterRoom(new AddTheaterRoomDto { TheaterId = 1 }));
    }
    
    [Test]
    public async Task UpdateTheaterRoom_ReturnsOk_WhenUpdated()
    {
        var fakeTheaterRoom = new TheaterRoomsWInfoDto { Id = 1 /* properties ter test */ };
        _mockTheaterRoomService.Setup(service => service.UpdateTheaterRoom(It.IsAny<TheaterRoomDto>())).ReturnsAsync(fakeTheaterRoom);

        var result = await _controller.UpdateTheaterRoom(1, new TheaterRoomDto { Id = 1 });

        Assert.That(result.Result, Is.InstanceOf<OkObjectResult>());
    }

    [Test]
    public async Task UpdateTheaterRoom_ReturnsBadRequest_WhenIdMismatch()
    {
        var result = await _controller.UpdateTheaterRoom(1, new TheaterRoomDto { Id = 2 });

        Assert.That(result.Result, Is.InstanceOf<BadRequestObjectResult>());
    }
    
    [Test]
    public async Task DeleteTheaterRoom_ReturnsNoContent_WhenDeleted()
    {
        _mockTheaterRoomService.Setup(service => service.DeleteTheaterRoom(It.IsAny<int>())).Returns(Task.CompletedTask);

        var result = await _controller.DeleteTheaterRoom(1);

        Assert.That(result, Is.InstanceOf<NoContentResult>());
    }

    [Test]
    public async Task DeleteTheaterRoom_ReturnsNotFound_WhenNotExists()
    {
        _mockTheaterRoomService.Setup(service => service.DeleteTheaterRoom(It.IsAny<int>())).Throws(new ArgumentException());

        var result = await _controller.DeleteTheaterRoom(1);

        Assert.That(result, Is.InstanceOf<NotFoundObjectResult>());
    }



}