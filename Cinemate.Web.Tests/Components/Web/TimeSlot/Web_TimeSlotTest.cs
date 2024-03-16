using Cinemate.Models.Dto;
using Cinemate.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Moq;
using NUnit.Framework;
using System.Threading.Tasks;
using Cinemate.Web.Components.Web.TimeSlot;

namespace Cinemate.Tests
{
    public class TimeSlotComponentTests
    {
        private Mock<IMovieService> _movieServiceMock;
        private Mock<ISelectedMovieService> _selectedMovieServiceMock;
        private Mock<NavigationManager> _navigationManagerMock;
        private Mock<IJSRuntime> _jsRuntimeMock;
        private Web_TimeSlot _component;

        [SetUp]
        public void Setup()
        {
            _movieServiceMock = new Mock<IMovieService>();
            _selectedMovieServiceMock = new Mock<ISelectedMovieService>();
            _navigationManagerMock = new Mock<NavigationManager>();
            _jsRuntimeMock = new Mock<IJSRuntime>();

            _component = new Web_TimeSlot
            {
                MovieService = _movieServiceMock.Object,
                SelectedMovieService = _selectedMovieServiceMock.Object,
                NavigationManager = _navigationManagerMock.Object,
                JSRuntime = _jsRuntimeMock.Object,
                ScreeningInfo = new ScreeningWithInfoDto { /* properties ter test */ }
            };
        }

        [Test]
        public async Task HandleTimeslotClick_NavigatesToCorrectUriAndStoresSelectedMovie()
        {
            var expectedMovie = new MovieWithCategoryDto { /* properties ter test */ };
            _movieServiceMock.Setup(service => service.GetMovie(It.IsAny<int>()))
                .ReturnsAsync(expectedMovie);

            var expectedUri = $"/kiosk/seat-reservation/{_component.ScreeningInfo.Id}";

            await _component.HandleTimeslotClick();

            _movieServiceMock.Verify(service => service.GetMovie(_component.ScreeningInfo.MovieId), Times.Once);

            _selectedMovieServiceMock.Verify(service => service.SetSelectedMovieAsync(It.Is<MovieDtoImage>(m => m.Id == expectedMovie.Id)), Times.Once);

            _navigationManagerMock.Verify(nm => nm.NavigateTo(expectedUri), Times.Once);

        }
    }
}
