namespace Cinemate.Models.Dto;

public class AddScreeningDto
{
    public int MovieId { get; set; }
    public int TheaterRoomId { get; set; }
    public DateTime MovieStart { get; set; }
}