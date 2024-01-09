using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Features.MenuItems.Commands.Request;

namespace OnlineFood.WebHost.Areas.Admin.Controllers;

[Area("Admin")]
public class MenuItemController : Controller
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
    public async Task<IActionResult> New(CreateMenuItemCommand command)
    {
        return View();
    }
}
