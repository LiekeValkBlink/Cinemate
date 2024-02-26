namespace Cinemate.Models.Dto;

public class ScreeningDto
{
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int TheaterRoomId { get; set; }
        public DateTime MovieStart { get; set; }
}