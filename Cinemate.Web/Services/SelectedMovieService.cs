using Cinemate.Models.Dto;

public interface ISelectedMovieService
{
    MovieDtoImage SelectedMovie { get; set; }
}

public class SelectedMovieService : ISelectedMovieService
{
    public MovieDtoImage SelectedMovie { get; set; }
}