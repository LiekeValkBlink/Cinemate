using System.ComponentModel.DataAnnotations.Schema;

namespace Cinemate.API.Entities;

[Table("seats_reserved")]
public class SeatReserved
{
    [Column("id")]
    public int Id { get; set; }
    
    [Column("seat_id")]
    public int SeatId { get; set; }

    [Column("reservation_id")]
    public int ReservationId { get; set; }
    
    public Seat Seat { get; set; }
    public Reservation Reservation { get; set; }
}