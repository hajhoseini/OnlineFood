using Microsoft.AspNetCore.Mvc;

namespace OnlineFood.WebHost.Areas.Admin.Controllers;

[Area("Admin")]
public class MenuItemController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
}
