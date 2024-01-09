using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Features.Wallets.Commands.Requests;

namespace OnlineFood.WebHost.Areas.Admin.Controllers;

[Area("Admin")]
public class WalletController : Controller
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
    public async Task<IActionResult> New(CreateWalletCommand command)
    {
        return View();
    }
}
