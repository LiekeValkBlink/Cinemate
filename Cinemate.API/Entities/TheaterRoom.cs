using System.ComponentModel.DataAnnotations.Schema;

namespace Cinemate.API.Entities;

[Table("theater_rooms")]
public class TheaterRoom
{
    [Column("id")]
    public int Id { get; set; }
    
    [Column("name")]
    public string Name { get; set; }
    

    [Column("theater_id")]
    public int TheaterId { get; set; }

    public Theater Theater { get; set; }
}