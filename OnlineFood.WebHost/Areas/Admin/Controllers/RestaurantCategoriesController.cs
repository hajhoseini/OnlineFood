using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Dtos.Message;

namespace OnlineFood.WebHost.Areas.Admin.Controllers;

[Area("Admin")]
public class RestaurantCategoriesController : Controller
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
    public IActionResult New(RestaurantCategoryDTO restaurantCategoryDTO)
    {
        return RedirectToAction("Index", "RestaurantCategories");
    }
}
