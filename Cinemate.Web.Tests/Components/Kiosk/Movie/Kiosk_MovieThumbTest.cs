using Cinemate.Models.Dto;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Moq;
using NUnit.Framework;
using System.Threading.Tasks;
using Cinemate.Web.Components.Kiosk.Movie;
using Cinemate.Web.Services;


namespace Cinemate.Tests
{
    public class MovieComponent2Tests
    {
        private Mock<IJSRuntime> _mockJSRuntime;
        private Mock<ISelectedMovieService> _mockSelectedMovieService;
        private Mock<INavigationService> _mockNavigationService; // Use this instead of NavigationManager

        [SetUp]
        public void Setup()
        {
            _mockJSRuntime = new Mock<IJSRuntime>();
            _mockSelectedMovieService = new Mock<ISelectedMovieService>();
            _mockNavigationService = new Mock<INavigationService>(); // Initialize the mock
        }

        [Test]
        public async Task SaveAndNavigate_WhenMovieIsNotNull_NavigatesToReservationPage()
        {
            var component = new Kiosk_MovieThumb()
            {
                JsRuntime = _mockJSRuntime.Object,
                SelectedMovieService = _mockSelectedMovieService.Object,
                NavigationService = _mockNavigationService.Object, // Inject the mock service
                MovieId = 1 
            };

            var movie = new MovieDtoImage { Id = 1 }; 

            _mockSelectedMovieService.Setup(s => s.SetSelectedMovieAsync(It.IsAny<MovieDtoImage>())).Returns(Task.CompletedTask);
            _mockNavigationService.Setup(n => n.NavigateTo(It.IsAny<string>(), It.IsAny<bool>())); // Setup mock NavigationService

            await component.SaveAndNavigate(movie);

            _mockNavigationService.Verify(n => n.NavigateTo($"/kiosk/show-reservation/1", true), Times.Once); // Verify NavigationService is called
        }

        [Test]
        public async Task SaveAndNavigate_WhenMovieIsNull_NavigatesToHomePage()
        {
            var component = new Kiosk_MovieThumb()
            {
                JsRuntime = _mockJSRuntime.Object,
                SelectedMovieService = _mockSelectedMovieService.Object,
                NavigationService = _mockNavigationService.Object, // Inject the mock service
                MovieId = 1
            };
            
            await component.SaveAndNavigate(null); 

            _mockNavigationService.Verify(n => n.NavigateTo("/", true), Times.Once); // Verify NavigationService is called
        }
    }
}


public interface INavigationService
{
    void NavigateTo(string uri, bool forceLoad = false);
}

public class NavigationService : INavigationService
{
    private readonly NavigationManager _navigationManager;

    public NavigationService(NavigationManager navigationManager)
    {
        _navigationManager = navigationManager;
    }

    public void NavigateTo(string uri, bool forceLoad = false)
    {
        _navigationManager.NavigateTo(uri, forceLoad);
    }
}

