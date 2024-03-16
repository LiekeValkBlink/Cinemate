using Cinemate.API.Controllers;
using Cinemate.API.Services.ReservationService;
using Cinemate.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinemate.API.Tests.Controllers;

[TestFixture]
public class ReservationControllerTest
{
    private Mock<IReservationService> _mockReservationService;
    private ReservationController _controller;

    [SetUp]
    public void SetUp()
    {
        _mockReservationService = new Mock<IReservationService>();
        _controller = new ReservationController(_mockReservationService.Object);
    }

    [Test]
    public async Task GetAllReservations_ReturnsAllReservations()
    {
        var fakeReservations = new List<ReservationDto>
        {
            new ReservationDto { /* properties ter test */ },
            new ReservationDto { /* properties ter test */ }
        };
        _mockReservationService.Setup(service => service.GetAllReservations())
            .ReturnsAsync(fakeReservations);
        
        var actionResult = await _controller.GetAllReservations();
        
        Assert.That(actionResult, Is.Not.Null);
        Assert.That(actionResult.Result, Is.InstanceOf<OkObjectResult>());

        var okResult = actionResult.Result as OkObjectResult;
        Assert.That(okResult, Is.Not.Null);
        Assert.That(okResult.StatusCode, Is.EqualTo(200));

        var reservationsResult = okResult.Value as IEnumerable<ReservationDto>;
        Assert.That(reservationsResult, Is.Not.Null);
        Assert.That(reservationsResult, Is.EquivalentTo(fakeReservations));
    }
}