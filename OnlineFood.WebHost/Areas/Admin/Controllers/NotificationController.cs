using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Features.Notifications.Commands.Requests;

namespace OnlineFood.WebHost.Areas.Admin.Controllers;

[Area("Admin")]
public class NotificationController : Controller
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
    public async Task<IActionResult> New(CreateNotificationCommand command)
    {
        return View();
    }
}
