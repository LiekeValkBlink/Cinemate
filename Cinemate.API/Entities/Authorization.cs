using System.ComponentModel.DataAnnotations.Schema;

namespace Cinemate.API.Entities;

[Table("authorizations")]
public class Authorization
{
    [Column("id")]
    public int Id { get; set; }
    [Column("descriptions")]
    public string Description { get; set; }
}