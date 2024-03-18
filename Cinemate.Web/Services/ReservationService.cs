using System.Net.Http.Json;
using System.Text.Json;
using Cinemate.Models.Dto;
using Cinemate.Web.Services.Contracts;
using Microsoft.JSInterop;

namespace Cinemate.Web.Services;

// Service class responsible for handling reservation-related operations
    public class ReservationService : IReservationService
    {
        private readonly HttpClient _httpClient;
        private readonly IJSRuntime _jsRuntime;
        private const string ReservationKey = "ReservationService";
        private const string SecretReservationKey = "SecretReservationService";

        // Constructor to initialize the service with an HttpClient instance and an IJSRuntime instance
        public ReservationService(HttpClient httpClient, IJSRuntime jsRuntime)
        {
            _httpClient = httpClient;
            _jsRuntime = jsRuntime;
        }

        // Method to retrieve a pre-reservation from local session storage
        public async Task<PreReservationDto> GetLocalPreReservation()
        {
            var json = await _jsRuntime.InvokeAsync<string>("sessionStorage.getItem", ReservationKey);
            return json != null ? JsonSerializer.Deserialize<PreReservationDto>(json) : null;
        }

        // Method to retrieve a pre-reservation for a secret movie from local session storage
        public async Task<SecretMoviePreReservation> GetLocalSecretMoviePreReservation()
        {
            var json = await _jsRuntime.InvokeAsync<string>("sessionStorage.getItem", SecretReservationKey);
            return json != null ? JsonSerializer.Deserialize<SecretMoviePreReservation>(json) : null;
        }

        // Method to set a pre-reservation in local session storage
        public async Task SetLocalPreReservation(PreReservationDto preReservation)
        {
            var json = JsonSerializer.Serialize(preReservation);
            await _jsRuntime.InvokeVoidAsync("sessionStorage.setItem", ReservationKey, json);
        }

        // Method to set a pre-reservation for a secret movie in local session storage
        public async Task SetLocalSecretMoviePreReservation(SecretMoviePreReservation preReservation)
        {
            var json = JsonSerializer.Serialize(preReservation);
            await _jsRuntime.InvokeVoidAsync("sessionStorage.setItem", SecretReservationKey, json);
        }

        // Method to fetch all reservations from the API
        public async Task<IEnumerable<ReservationDto>> GetAllReservations()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<IEnumerable<ReservationDto>>("api/reservation");
            }
            catch (HttpRequestException ex)
            {
                throw new Exception("Failed to fetch reservations. Please try again later.", ex);
            }
        }

        // Method to add a new reservation via the API
        public async Task<ReservationDto> AddReservation(AddReservationDto reservation)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("api/reservation", reservation);
                response.EnsureSuccessStatusCode(); // Throws if HTTP response status is not a success code
                return await response.Content.ReadFromJsonAsync<ReservationDto>();
            }
            catch (HttpRequestException ex)
            {
                throw new Exception("Failed to add reservation. Please try again later.", ex);
            }
        }

        // Method to fetch a single reservation by its ID from the API
        public async Task<ReservationDto> GetSingleReservation(int id)
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<ReservationDto>($"api/reservation/{id}");
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Failed to fetch reservation with ID {id}. Please try again later.", ex);
            }
        }

        // Method to add a reservation for a secret movie via the API
        public async Task<SecretMoviePreReservation> AddSecretMovieReservation(SecretMovieDto secretMovie)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("api/reservation/secretmovie", secretMovie);
                response.EnsureSuccessStatusCode(); // Throws if HTTP response status is not a success code
                return await response.Content.ReadFromJsonAsync<SecretMoviePreReservation>();
            }
            catch (HttpRequestException ex)
            {
                throw new Exception("Failed to add secret movie reservation. Please try again later.", ex);
            }
        }
    }