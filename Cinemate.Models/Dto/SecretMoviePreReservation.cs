namespace Cinemate.Models.Dto;

public class SecretMoviePreReservation
{
    public int ScreeningId { get; set; }
    public int SeatId { get; set; }
    public List<int> PromoCode { get; set; }
}