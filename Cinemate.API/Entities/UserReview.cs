using System.ComponentModel.DataAnnotations.Schema;

namespace Cinemate.API.Entities;

[Table("user_reviews")]
public class UserReview
{
    [Column("id")]
    public int Id { get; set; }

    [Column("user_id")]
    public int UserId { get; set; }

    [Column("screening_id")]
    public int ScreeningId { get; set; }

    [Column("review")]
    public string Review { get; set; }

    public User User { get; set; }
    public Screening Screening { get; set; }
}