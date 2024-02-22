namespace Cinemate.Models.Dto;

public class MovieDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Duration { get; set; }
    public int ReleaseYear { get; set; }
    public int MovieCategoryId { get; set; }
    public string Director { get; set; }
    public string Cast { get; set; }
    public decimal Review { get; set; }
    public string Kijkwijzers { get; set; }
}