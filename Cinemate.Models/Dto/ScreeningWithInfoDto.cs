namespace Cinemate.Models.Dto;

public class ScreeningWithInfoDto
{
    public int Id { get; set; }
    public int MovieId { get; set; }
    public string MovieName { get; set; }
    public int TheaterRoomId { get; set; }
    public string TheaterName { get; set; }
    public DateTime MovieStart { get; set; }
}