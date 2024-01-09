using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Features.Cities.Commands.Requests;

namespace OnlineFood.WebHost.Areas.Admin.Controllers;

[Area("Admin")]
public class CityController : Controller
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
    public async Task<IActionResult> New(CreateCityCommand command)
    {
        return View();
    }
}
