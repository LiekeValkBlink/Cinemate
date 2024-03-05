namespace Cinemate.Web.Components.User.Seat;

public partial class Seat
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
