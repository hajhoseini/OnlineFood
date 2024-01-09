using Microsoft.AspNetCore.Mvc;

namespace OnlineFood.WebHost.Areas.Admin.Controllers;

[Area("Admin")]
public class ProvinceController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
}
