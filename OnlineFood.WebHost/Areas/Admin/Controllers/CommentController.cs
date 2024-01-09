using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Features.Comments.Commands.Requests;

namespace OnlineFood.WebHost.Areas.Admin.Controllers;

[Area("Admin")]
public class CommentController : Controller
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
    public async Task<IActionResult> New(CreateCommentCommand command)
    {
        return View();
    }
}
