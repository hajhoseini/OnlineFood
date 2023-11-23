﻿using AutoMapper;
using Microsoft.AspNetCore.Identity;
using OnlineFood.Application.Dtos.Users;
using OnlineFood.Domain.Entities.Users;
using OnlineFood.Domain.InterfaceRepositories.Users;

namespace OnlineFood.Application.Services.Users.Commands;

public class UserCommandService : IUserCommandService
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;
    private readonly SignInManager<User> _signInManager;
    private readonly UserManager<User> _userManager;

    public UserCommandService(IUserRepository userRepository, IMapper mapper, UserManager<User> UserManager, SignInManager<User> SignInManager)
    {
        _userRepository = userRepository;
        _mapper = mapper;
        _userManager = UserManager;
        _signInManager = SignInManager;
    }


    public async Task<bool> Login(LoginDto dto)
    {
        var result =
            await _signInManager.PasswordSignInAsync(dto.Username, dto.password, dto.RememberMe,
                lockoutOnFailure: false);
        if (result.Succeeded)
        {
            return true;
        }
        else
        {
            return false;
        }
    }    public async Task<bool> Register(RegisterViewModel dto)
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

}