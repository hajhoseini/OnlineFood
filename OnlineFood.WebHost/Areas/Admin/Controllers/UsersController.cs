using Microsoft.AspNetCore.Mvc;

namespace OnlineFood.WebHost.Areas.Admin.Controllers;

[Area("Admin")]
public class UsersController : Controller
{
	[HttpGet]
	public IActionResult Index()
	{
		return View();
	}
}