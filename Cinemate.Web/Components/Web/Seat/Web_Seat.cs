namespace Cinemate.Web.Components.Web.Seat;

public partial class Web_Seat
{
    public int Row { get; set; }
    public int Number { get; set; }
    public SeatStatus Status { get; set; }
}

public enum SeatStatus
{
    Free,
    Selected,
    Occupied
}
