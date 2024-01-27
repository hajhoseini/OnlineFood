using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Dtos.Users;
using OnlineFood.Application.Features.Users.Queries.Requests;

namespace OnlineFood.WebHost.Areas.Restaurant.Controllers;

[Area("Restaurant")]
public class LoginController : Controller
{
    private readonly IMediator _mediator;

    public LoginController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(LoginDto dto)
    {
        /*var res = await _mediator.Send(new LoginQuery() { login = dto });
		if (res == false)
		{
			ViewBag.Error = "نام کاربری یا کلمه عبور اشتباه است";
			return View(dto);
		}*/
        return RedirectToAction("Index", "Home");
    }
}