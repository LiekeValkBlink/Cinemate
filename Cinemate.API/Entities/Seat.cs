using System.ComponentModel.DataAnnotations.Schema;

namespace Cinemate.API.Entities;

[Table("seats")]
public class Seat
{
    [Column("id")]
    public int Id { get; set; }
    
    [Column("row")]
    public int Row { get; set; }

    [Column("number")]
    public int Number { get; set; }

    [Column("theater_room_id")]
    public int TheaterRoomId { get; set; }

    public TheatherRoom TheatherRoom { get; set; }
}