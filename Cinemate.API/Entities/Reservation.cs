using System.ComponentModel.DataAnnotations.Schema;

namespace Cinemate.API.Entities;

[Table("reservations")]
public class Reservation
{
    [Column("id")]
    public int Id { get; set; }
    [Column("screening_id")]
    public int ScreeningId { get; set; }
    
    [Column("paid")]
    public bool Paid { get; set; }

    [Column("user_id")]
    public int UserId { get; set; }

    [Column("employee_id")]
    public int? EmployeeId { get; set; }
    
    [Column("price")]
    public decimal Price { get; set; }
    
    [Column("payment_type")]
    public string PaymentType { get; set; }

    public Screening Screening { get; set; }
    public User User { get; set; }
    public Employee Employee { get; set; }
}