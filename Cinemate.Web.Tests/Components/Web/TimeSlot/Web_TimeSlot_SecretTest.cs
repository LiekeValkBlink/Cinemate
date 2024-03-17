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
    private Mock<NavigationManager> mockNavigationManager;

    [SetUp]
    public void SetUp()
    {
        mockReservationService = new Mock<IReservationService>();
        mockSelectedMovieService = new Mock<ISelectedMovieService>();
        mockNavigationManager = new Mock<NavigationManager>();
    }

    [Test]
    public async Task HandleTimeslotClick_SuccessfulReservation_NavigatesCorrectly()
    {
        var expectedReservationResult = new SecretMoviePreReservation();
        mockReservationService.Setup(x => x.AddSecretMovieReservation(It.IsAny<SecretMovieDto>()))
            .ReturnsAsync(expectedReservationResult);


        var component = new Web_TimeSlot_Secret() 
        {
            ReservationService = mockReservationService.Object,
            SelectedMovieService = mockSelectedMovieService.Object,
            NavigationManager = mockNavigationManager.Object,
            ScreeningInfo = new ScreeningWithInfoDto()
        };
        await component.HandleTimeslotClick();

        mockReservationService.Verify(x => x.AddSecretMovieReservation(It.IsAny<SecretMovieDto>()), Times.Once);
        mockReservationService.Verify(x => x.SetLocalSecretMoviePreReservation(expectedReservationResult), Times.Once);
        mockSelectedMovieService.Verify(x => x.SetSelectedMovieAsync(It.IsAny<MovieDtoImage>()), Times.Once);
        var expectedUrl = $"tickets-and-payment?SecretMovie=true";
        mockNavigationManager.Verify(x => x.NavigateTo(expectedUrl, true), Times.Once);
    }
}