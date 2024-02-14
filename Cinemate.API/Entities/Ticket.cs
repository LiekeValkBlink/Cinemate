using System.ComponentModel.DataAnnotations.Schema;

namespace Cinemate.API.Entities;

[Table("tickets")]
public class Ticket
{
    [Column("id")]
    public int Id { get; set; }
    
    [Column("reservation_id")]
    public int ReservationId { get; set; }

    [Column("base_price")]
    public decimal BasePrice { get; set; }

    [Column("price_after_discount")]
    public decimal PriceAfterDiscount { get; set; }

    public Reservation Reservation { get; set; }
    public List<TicketPromoCodes> TicketPromoCodes { get; set; }
}