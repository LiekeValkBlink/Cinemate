using System.ComponentModel.DataAnnotations.Schema;

namespace Cinemate.API.Entities;

[Table("promo_codes")]
public class PromoCode
{
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; }

    [Column("active")]
    public bool Active { get; set; }

    [Column("uses_left")]
    public int? UsesLeft { get; set; }

    [Column("discount")]
    public string Discount { get; set; }

    [Column("discount_type")]
    public string DiscountType { get; set; }
    
    public List<TicketPromoCodes> TicketPromoCodes { get; set; }
    
}