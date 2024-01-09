using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Features.Provinces.Commands.Requests;

namespace OnlineFood.WebHost.Areas.Admin.Controllers;

[Area("Admin")]
public class ProvinceController : Controller
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
    public async Task<IActionResult> New(CreateProvinceCommand command)
    {
        return View();
    }
}
