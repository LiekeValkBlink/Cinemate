using System.ComponentModel.DataAnnotations.Schema;

namespace Cinemate.API.Entities;

[Table("movie_categories")]
public class MovieCategory
{
    [Column("id")]
    public int Id { get; set; }
    [Column("name")]
    public string Name { get; set; }
}