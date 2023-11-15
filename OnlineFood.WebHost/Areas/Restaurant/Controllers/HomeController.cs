using Microsoft.AspNetCore.Mvc;

namespace OnlineFood.WebHost.Areas.Restaurant.Controllers
{
    [Area("Restaurant")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
