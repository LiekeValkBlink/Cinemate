using Bunit;
using Cinemate.Models.Dto;
using Cinemate.Web.Services.Contracts;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Cinemate.Web.Pages.Admin;
using NUnit.Framework;
using TestContext = Bunit.TestContext;

namespace Cinemate.Web.Tests.Pages.Admin;

[TestFixture]
public class SeatsTest
{
    private Mock<ISeatsService> mockSeatsService;
    private Mock<ITheaterRoomService> mockTheaterRoomService;
    private TestContext ctx;

    [SetUp]
    public void SetUp()
    {
        mockSeatsService = new Mock<ISeatsService>();
        mockTheaterRoomService = new Mock<ITheaterRoomService>();
        
        mockSeatsService.Setup(service => service.GetAllSeats()).ReturnsAsync(new List<SeatsWInfoDto>
        {
            new SeatsWInfoDto { Id = 1, Row = 1, Number = 1, TheaterRoomId = 1, TheaterName = "Main" },
            new SeatsWInfoDto { Id = 2, Row = 1, Number = 2, TheaterRoomId = 1, TheaterName = "Main" }
        });

        mockTheaterRoomService.Setup(service => service.GetAllTheaterRooms()).ReturnsAsync(new List<TheaterRoomsWInfoDto>
        {
            new TheaterRoomsWInfoDto { Id = 1, Name = "Main" }
        });
        
        ctx = new TestContext();
        ctx.Services.AddScoped(_ => mockSeatsService.Object);
        ctx.Services.AddScoped(_ => mockTheaterRoomService.Object);
    }

    [Test]
    public async Task Seats_InitializesCorrectly()
    {
        var component = ctx.RenderComponent<Seats>();

        mockSeatsService.Verify(service => service.GetAllSeats(), Times.Once);
        mockTheaterRoomService.Verify(service => service.GetAllTheaterRooms(), Times.Once);

        Assert.That(component.Markup.Contains("Main"), Is.True);
        Assert.That(component.Markup.Contains("Row A"), Is.True);

        Assert.That(component.FindAll("tr").Count, Is.EqualTo(2));
    }
}
