using Microsoft.AspNetCore.Identity;
using OnlineFood.Application.DTOs.Users;
using OnlineFood.Domain.Entities.Users;

namespace OnlineFood.Application.Services.Users.Commands;

public class UserCommandService : IUserCommandService
{
    private readonly SignInManager<User> _signInManager;
    private readonly UserManager<User> _userManager;

    public UserCommandService(UserManager<User> UserManager, SignInManager<User> SignInManager)
    {
        _userManager = UserManager;
        _signInManager = SignInManager;
    }

    public async Task<bool> Login(LoginDTO dto)
    {
        var result = await _signInManager.PasswordSignInAsync(dto.Username,
                                                            dto.password,
                                                            dto.RememberMe,
                                                            lockoutOnFailure: false);
        if (result.Succeeded)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public async Task<bool> Register(RegisterViewModel dto)
    {
        var user = new User { UserName = dto.UserName, Email = dto.Email };
        var result = await _userManager.CreateAsync(user, dto.Password);

        if (result.Succeeded)
        {
            await _signInManager.SignInAsync(user, isPersistent: false);
            return true;
        }

        return false;
    }

    public async Task<bool> SignOutAsync()
    {
        await _signInManager.SignOutAsync();
        return true;
    }

    public async Task<bool> ChangePassword(ChangePasswordDTO dto)
    {
        var user = await _userManager.FindByNameAsync(dto.UserName);
        var result = await _userManager.ChangePasswordAsync(user, dto.CurrentPassword, dto.NewPassword);

        if (result.Succeeded)
        {
            await _signInManager.SignInAsync(user, isPersistent: false);
            return true;
        }

        return false;
    }
}