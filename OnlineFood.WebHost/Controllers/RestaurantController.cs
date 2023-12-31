using Microsoft.AspNetCore.Mvc;

namespace OnlineFood.WebHost.Controllers
{
    public class RestaurantController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
