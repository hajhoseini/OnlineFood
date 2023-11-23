namespace OnlineFood.Application.Dtos.Users;

public class LoginDto
{
    public string  Username { get; set; }
    public string password { get; set; }
    public bool RememberMe { get; set; }
}