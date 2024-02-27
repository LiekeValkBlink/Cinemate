using System.ComponentModel.DataAnnotations.Schema;

namespace Cinemate.API.Entities;

[Table("screenings")]
public class Screening
{
    [Column("id")]
    public int Id { get; set; }
    [Column("movie_id")]
    public int MovieId { get; set; }

    [Column("theater_room_id")]
    public int TheaterRoomId { get; set; }

    [Column("movie_start")]
    public DateTime MovieStart { get; set; }

    public Movie Movie { get; set; }
    public TheaterRoom TheaterRoom { get; set; }
    
}