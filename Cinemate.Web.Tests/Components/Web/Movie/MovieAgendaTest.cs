using Cinemate.Models.Dto;
using Cinemate.Web.Services.Contracts;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Cinemate.Web.Components.Web.Movie;

namespace Cinemate.Tests
{
    public class SecretMovieTests
    {
        private Mock<IScreeningService> _mockScreeningService;
        private Mock<IReservationService> _mockReservationService;
        private MovieAgenda _razorComponent;

        [SetUp]
        public void Setup()
        {
            _mockScreeningService = new Mock<IScreeningService>();
            _mockReservationService = new Mock<IReservationService>();
            _razorComponent = new MovieAgenda();

            _razorComponent.ScreeningService = _mockScreeningService.Object;
            _razorComponent.ReservationService = _mockReservationService.Object;
        }

        [Test]
        public async Task LoadSecretMovieReservations_FiltersAndAddsReservations()
        {
            var testDate = DateTime.Today.AddDays(1);
            var screenings = new List<ScreeningWithInfoDto>
            {
                // Test data kan hier geplaatst worden
            };
            _mockScreeningService.Setup(service => service.GetAllScreenings()).ReturnsAsync(screenings);

            _mockReservationService.Setup(service => service.AddSecretMovieReservation(It.IsAny<SecretMovieDto>()))
                .ReturnsAsync((SecretMovieDto dto) => new SecretMoviePreReservation { /* properties ter test */ });

            _razorComponent.SelectedDate = testDate;

            // Using reflection to invoke LoadSecretMovieReservations
            var methodInfo = _razorComponent.GetType().GetMethod("LoadSecretMovieReservations", BindingFlags.NonPublic | BindingFlags.Instance);
            await (Task)methodInfo.Invoke(_razorComponent, null);

            // Using reflection to access secretMovieReservations
            var fieldInfo = _razorComponent.GetType().GetField("secretMovieReservations", BindingFlags.NonPublic | BindingFlags.Instance);
            var secretMovieReservations = (List<SecretMoviePreReservation>)fieldInfo.GetValue(_razorComponent);

            Assert.That(secretMovieReservations, Is.Not.Empty);

            _mockScreeningService.Verify(service => service.GetAllScreenings(), Times.Once);
            _mockReservationService.Verify(service => service.AddSecretMovieReservation(It.IsAny<SecretMovieDto>()), Times.AtLeastOnce);
        }
    }
}
