using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Features.AccountTransactions.Commands.Requests;

namespace OnlineFood.WebHost.Areas.Admin.Controllers;

[Area("Admin")]
public class AccountTransactionController : Controller
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
    public async Task<IActionResult> New(CreateAccountTransactionCommand command)
    {
        return View();
    }
}
