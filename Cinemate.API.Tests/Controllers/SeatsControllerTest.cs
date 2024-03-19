using Cinemate.API.Controllers;
using Cinemate.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;
using Cinemate.API.Services.TheatherService;

namespace Cinemate.API.Tests.Controllers;

[TestFixture]
public class SeatsControllerTest
{
    private Mock<ISeatsService> _mockSeatsService;
    private SeatsController _controller;

    [SetUp]
    public void SetUp()
    {
        _mockSeatsService = new Mock<ISeatsService>();
        _controller = new SeatsController(_mockSeatsService.Object);
    }

    [Test]
    public async Task GetAllSeats_ReturnsAllSeats()
    {
        var fakeSeats = new List<SeatsWInfoDto>
        {
            new SeatsWInfoDto
            {
                /* properties ter test*/
            },
            new SeatsWInfoDto
            {
                /* properties ter test */
            }
        };
        _mockSeatsService.Setup(service => service.GetAllSeats())
            .ReturnsAsync(fakeSeats);
        
        var result = await _controller.GetAllSeats();
 
        Assert.That(result.Result, Is.InstanceOf<OkObjectResult>());
        var okResult = result.Result as OkObjectResult;
        Assert.That(okResult.StatusCode, Is.EqualTo(200));
        var seatsResult = okResult.Value as IEnumerable<SeatsWInfoDto>;
        Assert.That(seatsResult, Is.Not.Null);
        Assert.That(seatsResult, Has.Count.EqualTo(fakeSeats.Count));
    }

    [Test]
    public async Task GetSeatById_ReturnsSeat_WhenSeatExists()
    {
        var seatId = 1;
        var fakeSeat = new SeatsWInfoDto { Id = seatId, /* Initialize other properties as needed */ };
        _mockSeatsService.Setup(x => x.GetSeatById(seatId)).ReturnsAsync(fakeSeat);

        var result = await _controller.GetSeatById(seatId);

        Assert.That(result.Result, Is.InstanceOf<OkObjectResult>());
        var okResult = result.Result as OkObjectResult;
        Assert.That(okResult.Value, Is.EqualTo(fakeSeat));
    }

    [Test]
    public async Task GetSeatById_ReturnsNotFound_WhenSeatDoesNotExist()
    {
        var seatId = 1;
        _mockSeatsService.Setup(x => x.GetSeatById(seatId)).ReturnsAsync((SeatsWInfoDto)null);

        var result = await _controller.GetSeatById(seatId);

        Assert.That(result.Result, Is.InstanceOf<NotFoundResult>());
    }

    [Test]
    public async Task GetSeatsByTheaterRoomId_ReturnsSeats_WhenTheyExist()
    {

        var theaterRoomId = 1;
        var fakeSeats = new List<SeatsWInfoDto>
        {
            new SeatsWInfoDto
            {
                /* properties ter test */
            },
            new SeatsWInfoDto
            {
                /* properties ter test */
            }
        };
        _mockSeatsService.Setup(x => x.GetSeatsByTheaterRoomId(theaterRoomId)).ReturnsAsync(fakeSeats);

        var result = await _controller.GetSeatsByTheaterRoomId(theaterRoomId);

        Assert.That(result.Result, Is.InstanceOf<OkObjectResult>());
        var okResult = result.Result as OkObjectResult;
        Assert.That(okResult.Value, Is.EquivalentTo(fakeSeats));
    }

    [Test]
    public async Task AddSeat_ReturnsCreatedAtAction_WhenSeatIsAdded()
    {
        var fakeSeatDto = new AddSeatsDto
        {
            /* properties ter test */
        };
        var fakeAddedSeat = new SeatsWInfoDto { Id = 1, /* properties ter test */ };
        _mockSeatsService.Setup(x => x.AddSeat(fakeSeatDto)).ReturnsAsync(fakeAddedSeat);

        var result = await _controller.AddSeat(fakeSeatDto);

        Assert.That(result.Result, Is.InstanceOf<CreatedAtActionResult>());
        var createdAtResult = result.Result as CreatedAtActionResult;
        Assert.That(createdAtResult.Value, Is.EqualTo(fakeAddedSeat));
        Assert.That(createdAtResult.ActionName, Is.EqualTo("GetSeatById"));
    }
    
    [Test]
    public async Task UpdateSeat_ReturnsOkWithUpdatedSeat_WhenSeatExists()
    {
        var fakeSeatId = 1;
        var fakeSeatDto = new SeatsDto { /* properties ter test */ };
        var fakeUpdatedSeat = new SeatsWInfoDto { Id = fakeSeatId, /* properties ter test */ };
        _mockSeatsService.Setup(s => s.UpdateSeat(fakeSeatId, fakeSeatDto)).ReturnsAsync(fakeUpdatedSeat);

        var result = await _controller.UpdateSeat(fakeSeatId, fakeSeatDto);
        
        Assert.That(result, Is.TypeOf<OkObjectResult>());
        var okResult = result as OkObjectResult;
        Assert.That(okResult.Value, Is.EqualTo(fakeUpdatedSeat));
    }
    
}