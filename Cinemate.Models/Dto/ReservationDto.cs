namespace Cinemate.Models.Dto;

public class ReservationDto
{
    public int Id { get; set; }
    public int ScreeningId { get; set; }
    public DateTime MovieStart { get; set; }
    public string MovieName { get; set; }
    public bool Paid { get; set; }
    public List<SeatsWInfoDto> ReservedSeats { get; set; }
    public string TheaterRoomName { get; set; }
    public List<PromoCodeInfoDto> PromoCodes { get; set; }
}