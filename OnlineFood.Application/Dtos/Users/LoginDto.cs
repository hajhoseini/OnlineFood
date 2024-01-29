namespace OnlineFood.Application.DTOs.Users;

public class LoginDTO
{
    public string  Username { get; set; }
    public string password { get; set; }
    public bool RememberMe { get; set; }
}