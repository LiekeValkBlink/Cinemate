using Cinemate.Models.Dto;
using Cinemate.Web.Services.Contracts;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using Cinemate.Web.Components.Web.TimeSlot;

namespace Cinemate.Web.Tests.Components.Web.TimeSlot;

[TestFixture]
public class TimeSlotSelectorTest
{
    private Bunit.TestContext ctx;
    private Mock<IScreeningService> mockScreeningService;

    [SetUp]
    public void SetUp()
    {
        ctx = new Bunit.TestContext();
        mockScreeningService = new Mock<IScreeningService>();

        mockScreeningService.Setup(s => s.GetAllScreenings()).ReturnsAsync(new List<ScreeningWithInfoDto>
        {
            new ScreeningWithInfoDto { MovieId = 1, MovieStart = DateTime.Now.AddHours(2) },
            new ScreeningWithInfoDto { MovieId = 1, MovieStart = DateTime.Now.AddDays(1) }, 
        });

        ctx.Services.AddSingleton<IScreeningService>(mockScreeningService.Object);
    }

    [TearDown]
    public void TearDown()
    {
        ctx.Dispose();
    }

    [Test]
    public async Task TimeSlotSelector_InitializesAndFiltersScreeningsCorrectly()
    {
        var movieId = 1;
        var selectedDate = DateTime.Now;

        var component = ctx.RenderComponent<TimeSlotSelector>(parameters => parameters
            .Add(p => p.MovieId, movieId)
            .Add(p => p.SelectedDate, selectedDate));

        await Task.Delay(100); 
        var screeningsProperty = component.Instance.GetType().GetProperty("FilteredScreenings", BindingFlags.NonPublic | BindingFlags.Instance);
        var screenings = component.Instance.GetFilteredScreenings(); 
        Assert.That(screenings, Is.Not.Null, "Screenings should not be null.");
        Assert.That(screenings, Is.Not.Empty, "There should be filtered screenings.");
        Assert.That(screenings, Has.All.Matches<ScreeningWithInfoDto>(s => s.MovieId == movieId && s.MovieStart.Date == selectedDate.Date), "All screenings should match the criteria.");
    }
}
