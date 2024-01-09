using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Features.Addresses.Commands.Requests;
using OnlineFood.Application.Features.WorkTimes.Commands.Request;

namespace OnlineFood.WebHost.Areas.Admin.Controllers;

[Area("Admin")]
public class WorkTimeController : Controller
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
    public async Task<IActionResult> New(CreateWorkTimeCommand command)
    {
        return View();
    }
}
