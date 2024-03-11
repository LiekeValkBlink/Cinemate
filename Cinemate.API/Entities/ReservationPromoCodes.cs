using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Cinemate.API.Entities;

[Table("reservation_promo_codes")]
[PrimaryKey(nameof(ReservationId), nameof(PromoCodeId))]
public class ReservationPromoCodes
{
    public int ReservationId { get; set; }
    public int PromoCodeId { get; set; }

    public Reservation Reservation { get; set; }
    public PromoCode PromoCode { get; set; }
}