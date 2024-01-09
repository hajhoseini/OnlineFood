using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Features.Addresses.Commands.Requests;
using OnlineFood.Application.Features.RestaurantCategories.Commands.Requests;

namespace OnlineFood.WebHost.Areas.Admin.Controllers;

[Area("Admin")]
public class AddressController : Controller
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
    public async Task<IActionResult> New(CreateAddressCommand command)
    {
        return View();
    }
}
