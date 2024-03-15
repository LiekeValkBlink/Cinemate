using System.ComponentModel.DataAnnotations;
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
    
    [Column("release_country")]
    public string ReleaseCountry { get; set; }

    [Column("movie_category_id")]
    public int MovieCategoryId { get; set; }

    [Column("director")]
    public string Director { get; set; }
    
    [Column("actor_cast")]
    public string Cast { get; set; }
    
    [Column("review")]
    public decimal Review { get; set; }
    
    [Column("kijkwijzers")]
    public string Kijkwijzers { get; set; }
    
    [Column("three_dimensional")]
    public bool ThreeDimensional {get; set; }
    

    public MovieCategory MovieCategory { get; set; }
}