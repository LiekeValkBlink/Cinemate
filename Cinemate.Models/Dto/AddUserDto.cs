namespace Cinemate.Models.Dto;

public class AddUserDto
{
    public string Email { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
    public bool SubscribedToNewsletter { get; set; }
}