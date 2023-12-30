using MediatR;
using Microsoft.AspNetCore.Identity;
using OnlineFood.Application.Features.Users.Commands.Requests;
using OnlineFood.Domain.Entities.Users;

namespace OnlineFood.Application.Features.Users.Commands.RequestHandlers;

public class RegisterUserRequesthandler:IRequestHandler<RegisterUserRequest,bool>
{
    private readonly SignInManager<User> _signInManager;
    private readonly UserManager<User> _userManager;

    public RegisterUserRequesthandler(SignInManager<User> signInManager, UserManager<User> userManager)
    {
        _signInManager = signInManager;
        _userManager = userManager;
    }

    public async Task<bool> Handle(RegisterUserRequest request, CancellationToken cancellationToken)
    {
        var user = new User { UserName = request.Register.UserName, Email = request.Register.Email };
        var result = await _userManager.CreateAsync(user, request.Register.Password);

        if (result.Succeeded)
        {
            await _signInManager.SignInAsync(user, isPersistent: false);
            return true;
        }

        return false;
     }
}