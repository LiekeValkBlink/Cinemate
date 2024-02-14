using System.ComponentModel.DataAnnotations.Schema;

namespace Cinemate.API.Entities;

[Table("movies")]
public class Movie
{
    [Column("id")]
    public int Id { get; set; }
    
    [Column("title")]
    public string Title { get; set; }

    [Column("description")]
    public string Description { get; set; }

    [Column("duration")]
    public int Duration { get; set; }

    [Column("release_year")]
    public int ReleaseYear { get; set; }

    [Column("movie_category_id")]
    public int MovieCategoryId { get; set; }

    public MovieCategory MovieCategory { get; set; }
}