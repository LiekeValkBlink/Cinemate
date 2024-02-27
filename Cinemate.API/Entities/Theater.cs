using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinemate.API.Entities;

[Table("theaters")]
public class Theater
{
    [Column("id")]
    public int Id { get; set; }
    
    [Column("name")]
    public string Name { get; set; }

    [Column("street")]
    public string Street { get; set; }

    [Column("house_nr")]
    public string? HouseNr { get; set; }

    [Column("city")]
    public string City { get; set; }

    [Column("country")]
    [MaxLength(2)]
    public string Country { get; set; }
}