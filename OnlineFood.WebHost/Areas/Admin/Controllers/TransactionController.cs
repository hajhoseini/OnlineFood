using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Features.Transactions.Commands.Requests;

namespace OnlineFood.WebHost.Areas.Admin.Controllers;

[Area("Admin")]
public class TransactionController : Controller
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
    public async Task<IActionResult> New(CreateTransactionCommand command)
    {
        return View();
    }
}
