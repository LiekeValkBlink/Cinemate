using Cinemate.Models;
using Cinemate.Models.Dto;
using Cinemate.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Moq;
using NUnit.Framework;
using System.Threading.Tasks;
using Cinemate.Web.Components.Kiosk.Movie;

namespace Cinemate.Tests
{
    public class MovieComponent2Tests
    {
        private Mock<IJSRuntime> _mockJSRuntime;
        private Mock<ISelectedMovieService> _mockSelectedMovieService;
        private Mock<NavigationManager> _mockNavigationManager;

        [SetUp]
        public void Setup()
        {
            _mockJSRuntime = new Mock<IJSRuntime>();
            _mockSelectedMovieService = new Mock<ISelectedMovieService>();
            _mockNavigationManager = new Mock<NavigationManager>();
        }

        [Test]
        public async Task SaveAndNavigate_WhenMovieIsNotNull_NavigatesToReservationPage()
        {
            var component = new Kiosk_MovieThumb()
            {
                JSRuntime = _mockJSRuntime.Object,
                SelectedMovieService = _mockSelectedMovieService.Object,
                NavigationManager = _mockNavigationManager.Object,
                MovieId = 1 
            };

            var movie = new MovieDtoImage { Id = 1 }; 

            _mockSelectedMovieService.Setup(s => s.SetSelectedMovieAsync(It.IsAny<MovieDtoImage>())).Returns(Task.CompletedTask);
            _mockNavigationManager.Setup(n => n.NavigateTo(It.IsAny<string>(), It.IsAny<bool>()));

            await component.SaveAndNavigate(movie);

            _mockNavigationManager.Verify(n => n.NavigateTo($"/kiosk/show-reservation/1", true), Times.Once);
        }

        [Test]
        public async Task SaveAndNavigate_WhenMovieIsNull_NavigatesToHomePage()
        {
            var component = new Kiosk_MovieThumb()
            {
                JSRuntime = _mockJSRuntime.Object,
                SelectedMovieService = _mockSelectedMovieService.Object,
                NavigationManager = _mockNavigationManager.Object
            };
            await component.SaveAndNavigate(null); 

            _mockNavigationManager.Verify(n => n.NavigateTo("/", true), Times.Once);
        }
    }
}
