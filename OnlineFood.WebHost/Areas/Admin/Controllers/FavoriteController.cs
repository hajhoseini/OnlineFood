using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Features.Favorites.Commands.Requests;

namespace OnlineFood.WebHost.Areas.Admin.Controllers;

[Area("Admin")]
public class FavoriteController : Controller
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
    public async Task<IActionResult> New(CreateFavoriteCommand command)
    {
        return View();
    }
}
