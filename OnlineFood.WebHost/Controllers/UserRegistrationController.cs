using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.DTOs.Customers;
using OnlineFood.Application.Features.Customers.Commands.Requests;
using OnlineFood.Common;

namespace OnlineFood.WebHost.Controllers
{
    public class UserRegistrationController : Controller
    {
        private readonly IMediator _mediator;

        public UserRegistrationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterDTO dto)
        {
            ResultDTO result = await _mediator.Send(new RegisterCommand() { register = dto });
            if(!result.IsSuccess)
            {
                ViewBag.Error = result.Message;
                return View(dto);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
