using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Dtos.Users;
using OnlineFood.Application.Services.Users.Commands;
using System.Security.Claims;

namespace OnlineFood.WebHost.Controllers;

public class UserController : Controller
{
    private readonly IUserCommandService _userCommandService;

    public UserController(IUserCommandService UserCommandService)
    {
        _userCommandService = UserCommandService;
    }


    [HttpGet]
    public async Task<IActionResult> Login()
    {
        if (User.Identity.IsAuthenticated)
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).Replace("Controller", ""));
        return View(nameof(Login));
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Login(LoginDto dto)
    {
        if (User.Identity.IsAuthenticated)
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).Replace("Controller", ""));
        var result = await _userCommandService.Login(dto);
        if (result == true)
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).Replace("Controller", ""));
        return View();
    }

    [HttpGet]
    public async Task<IActionResult> Logout()
    {
        await _userCommandService.SignOutAsync();
        return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).Replace("Controller", ""));
    }

    [HttpGet]
    public async Task<IActionResult> New()
    {
        if (User.Identity.IsAuthenticated)
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).Replace("Controller", ""));
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> New(RegisterViewModel dto)
    {
        if (User.Identity.IsAuthenticated)
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).Replace("Controller", ""));
        var result = await _userCommandService.Register(dto);
        if (result == true)
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).Replace("Controller", ""));
        return View();
    }

    [HttpGet]
    [Authorize]
    public async Task<IActionResult> ChangePassword()
    {
        return View();
    }

    [HttpPost]
    [Authorize]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> ChangePassword(ChangePasswordDTO dto)
    {
        dto.id = User.FindFirstValue(ClaimTypes.NameIdentifier);
        dto.UserName = User.FindFirstValue(ClaimTypes.Name);
        dto.Email = User.FindFirstValue(ClaimTypes.Email);
        var result = await _userCommandService.ChangePassword(dto);
        if (result == true)
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).Replace("Controller", ""));
        return View();
    }

    [HttpGet]
    public IActionResult AccessDenied()
    {
        return View();
    }
}