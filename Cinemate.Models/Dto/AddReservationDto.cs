using System.Security.AccessControl;

namespace Cinemate.Models.Dto;

public class AddReservationDto
{
    public int ScreeningId { get; set; }
    public bool Paid { get; set; }
    public int UserId { get; set; }
    public int? EmployeeId { get; set; }
    public string PaymentType { get; set; }
    public List<int> SeatId { get; set; }
    public List<int> PromoCode { get; set; }
    public decimal Price { get; set; }
}