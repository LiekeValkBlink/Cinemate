using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using Cinemate.Web.Services.Contracts;
using Cinemate.Models.Dto;
using Cinemate.Web.Components.Web.TimeSlot;
using Microsoft.AspNetCore.Components;

[TestFixture]
public class SecretMovieComponentTests
{
    private Mock<IReservationService> mockReservationService;
    private Mock<ISelectedMovieService> mockSelectedMovieService;
    private FakeNavigationManager fakeNavigationManager; 

    [SetUp]
    public void SetUp()
    {
        mockReservationService = new Mock<IReservationService>();
        mockSelectedMovieService = new Mock<ISelectedMovieService>();
        fakeNavigationManager = new FakeNavigationManager();
    }

    [Test]
    public async Task HandleTimeslotClick_SuccessfulReservation_Navigates()
    {
        var expectedReservationResult = new SecretMoviePreReservation();
        mockReservationService.Setup(x => x.AddSecretMovieReservation(It.IsAny<SecretMovieDto>()))
            .ReturnsAsync(expectedReservationResult);

        var component = new Web_TimeSlot_Secret()
        {
            ReservationService = mockReservationService.Object,
            SelectedMovieService = mockSelectedMovieService.Object,
            NavigationManager = fakeNavigationManager,
            ScreeningInfo = new ScreeningWithInfoDto()
        };

        await component.HandleTimeslotClick();

        // Using Assert.That for a more fluent assertion
        Assert.That(fakeNavigationManager.HasNavigated(), Is.True, "Expected to navigate, but did not.");
    }


}

public class FakeNavigationManager : NavigationManager
{
    public List<(string Uri, bool ForceLoad)> Navigations { get; } = new List<(string Uri, bool ForceLoad)>();

    public FakeNavigationManager()
    {
        Initialize("http://example.com/", "http://example.com/");
    }

    protected override void NavigateToCore(string uri, bool forceLoad)
    {
        Navigations.Add((uri, forceLoad));
    }

    // New simple method to check if navigation has occurred
    public bool HasNavigated() => Navigations.Any();
}

