using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Cinemate.API.Entities;

[Table("ticket_promo_codes")]
[PrimaryKey(nameof(TicketId), nameof(PromoCodeId))]
public class TicketPromoCodes
{
    public int TicketId { get; set; }
    public int PromoCodeId { get; set; }

    public Ticket Ticket { get; set; }
    public PromoCode PromoCode { get; set; }
}