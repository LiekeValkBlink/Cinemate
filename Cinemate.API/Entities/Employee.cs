using System.ComponentModel.DataAnnotations.Schema;

namespace Cinemate.API.Entities;

[Table("employees")]
public class Employee
{
    [Column("id")]
    public int Id { get; set; }

    [Column("first_name")]
    public string FirstName { get; set; }

    [Column("last_name")]
    public string LastName { get; set; }

    [Column("email")]
    public string Email { get; set; }

    [Column("authorization_id")]
    public int AuthorizationId { get; set; }

    [Column("password")]
    public string Password { get; set; }

    public Authorization Authorization { get; set; }
}