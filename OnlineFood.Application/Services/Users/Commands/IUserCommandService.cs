using OnlineFood.Application.Dtos.Users;

namespace OnlineFood.Application.Services.Users.Commands;

public interface IUserCommandService
{
    Task<bool> Login(LoginDto dto);
    Task<bool> Register(RegisterViewModel dto);
    Task<bool> SignOutAsync();
    
    Task<bool> ChangePassword(ChangePasswordDTO dto);
}
