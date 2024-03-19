using Cinemate.Models.Dto;
using Cinemate.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;
using Cinemate.Web.Components.Kiosk.Movie;

namespace Cinemate.Tests
{
    public class MovieComponentTests
    {
        private Mock<IMovieService> mockMovieService;
        private Mock<IJSRuntime> mockJsRuntime;
        private Mock<NavigationManager> mockNavigationManager;
        private TestMovieComponent component;

        [SetUp]
        public void Setup()
        {
            mockMovieService = new Mock<IMovieService>();
            mockJsRuntime = new Mock<IJSRuntime>();
            mockNavigationManager = new Mock<NavigationManager>();

            component = new TestMovieComponent
            {
                MovieService = mockMovieService.Object,
                JSRuntime = mockJsRuntime.Object,
                NavigationManager = mockNavigationManager.Object
            };
        }

        [Test]
        public async Task OnInitializedAsync_LoadsMovies()
        {
            var movies = new List<MovieWithCategoryDto>
            {
                // Test data kan hier geplaatst worden
            };
            mockMovieService.Setup(service => service.GetMovies()).ReturnsAsync(movies);

            await component.TestOnInitializedAsync();

            Assert.That(component.TestAllMovies, Is.EqualTo(movies));
        }

        [Test]
        public async Task SaveAndNavigate_NavigatesToMovie()
        {
            var movieId = 1;
            var movieDtoImage = new MovieDtoImage { Id = movieId };

            await component.TestSaveAndNavigate(movieDtoImage);

            var expectedUrl = $"kiosk/show-reservation/{movieId}";
            mockNavigationManager.Verify(navigation => navigation.NavigateTo(expectedUrl, true), Times.Once);

        }
    }
    
    public class TestMovieComponent : Kiosk_Movie 
    {
        public new IMovieService MovieService { get; set; }
        public new IJSRuntime JSRuntime { get; set; }
        public new NavigationManager NavigationManager { get; set; }

        public async Task TestOnInitializedAsync() => await OnInitializedAsync();
        public async Task TestSaveAndNavigate(MovieDtoImage movie) => await SaveAndNavigate(movie);

        public IEnumerable<MovieWithCategoryDto> TestAllMovies => base.AllMovies;
    }
}

