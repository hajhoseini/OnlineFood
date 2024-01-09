using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Features.Menus.Commands.Requests;

namespace OnlineFood.WebHost.Areas.Admin.Controllers;

[Area("Admin")]
public class MenuCategoryController : Controller
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
    public async Task<IActionResult> New(CreateMenuCommand command)
    {
        return View();
    }
}
