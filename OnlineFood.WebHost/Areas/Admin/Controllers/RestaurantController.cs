using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Features.Restaurants.Commands.Requests;

namespace OnlineFood.WebHost.Areas.Admin.Controllers;

[Area("Admin")]
public class RestaurantController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult New()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> New(CreateRestaurantCommand command)
    {
        return View();
    }
}
