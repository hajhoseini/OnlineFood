using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Dtos.Message;

namespace OnlineFood.WebHost.Areas.Admin.Controllers;

[Area("Admin")]
public class MessagesController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    
    [HttpGet]
    public IActionResult Send()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Send(MessageDTO messageDTo)
    {
        return RedirectToAction("Index", "Messages");
    }
}
