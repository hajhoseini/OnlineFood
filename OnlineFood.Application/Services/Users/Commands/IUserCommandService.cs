using OnlineFood.Application.DTOs.Users;

namespace OnlineFood.Application.Services.Users.Commands;

public interface IUserCommandService
{
    Task<bool> Login(LoginDTO dto);
    Task<bool> Register(RegisterViewModel dto);
    Task<bool> SignOutAsync();
    
    Task<bool> ChangePassword(ChangePasswordDTO dto);
}
