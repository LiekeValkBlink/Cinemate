using Cinemate.Models;
using Cinemate.Models.Dto;
using Cinemate.Web.Services.Contracts;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinemate.Web.Components.Kiosk.Movie;

namespace Cinemate.Tests
{
    public class MovieComponent3Tests
    {
        [Test]
        public async Task OnInitializedAsync_PopulatesAllMoviesWithImage()
        {
            // Arrange
            var mockMovieService = new Mock<IMovieService>();
            var expectedMovies = new List<MovieWithCategoryDto>
            {
                new MovieWithCategoryDto { Id = 1, Title = "Movie 1" },
            };

            mockMovieService.Setup(service => service.GetMovies()).ReturnsAsync(expectedMovies);

            var component = new TestableMovieThumbContainer
            {
                MovieService = mockMovieService.Object
            };

            // Act
            await component.CallOnInitializedAsyncForTest();

            // Assert
            Assert.That(component.AllMoviesWithImage, Is.Not.Null);
            Assert.That(component.AllMoviesWithImage.Count(), Is.EqualTo(expectedMovies.Count));
            Assert.That(component.AllMoviesWithImage.First().Title, Is.EqualTo(expectedMovies.First().Title));
            Assert.That(component.AllMoviesWithImage.First().MoviePosterUrl, Is.EqualTo($"https://localhost:7201/images/posters/movie_{expectedMovies.First().Id}_image.jpg"));
        }
    }
    

        public class TestableMovieThumbContainer : Kiosk_MovieThumbContainer
        {
            public async Task CallOnInitializedAsyncForTest()
            {
                await OnInitializedAsync();
            }
        }
    }
    