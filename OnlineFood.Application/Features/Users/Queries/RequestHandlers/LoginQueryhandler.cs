using MediatR;
using Microsoft.AspNetCore.Identity;
using OnlineFood.Application.Features.Users.Queries.Requests;
using OnlineFood.Domain.Entities.Users;

namespace OnlineFood.Application.Features.Users.Queries.RequestHandlers;

public class LoginQueryhandler:IRequestHandler<LoginQuery,bool>
{
    private readonly SignInManager<User> _signInManager;
    private readonly UserManager<User> _userManager;

    public LoginQueryhandler(SignInManager<User> signInManager, UserManager<User> userManager)
    {
        _signInManager = signInManager;
        _userManager = userManager;
    }

    public async Task<bool> Handle(LoginQuery request, CancellationToken cancellationToken)
    {
        var result = await _signInManager.PasswordSignInAsync(request.login.Username, 
            request.login.password, 
            request.login.RememberMe,
            lockoutOnFailure: false);
        if (result.Succeeded)
        {
            return  true;
        }
        else
        {
            return  false;
        }
    }
}