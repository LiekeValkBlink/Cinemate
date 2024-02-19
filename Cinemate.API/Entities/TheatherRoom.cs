using System.ComponentModel.DataAnnotations.Schema;

namespace Cinemate.API.Entities;

[Table("theather_rooms")]
public class TheatherRoom
{
    [Column("id")]
    public int Id { get; set; }
    
    [Column("name")]
    public string Name { get; set; }

    [Column("seats_no")]
    public int SeatsNo { get; set; }

    [Column("theater_id")]
    public int TheaterId { get; set; }

    public Theather Theather { get; set; }
}