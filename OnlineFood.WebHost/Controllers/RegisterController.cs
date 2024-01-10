using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Features.Customers.Commands.Requests;

namespace OnlineFood.WebHost.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IMediator mediator;

        public RegisterController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(/*[FromBody]*/ CreateCustomerCommand command)
        {
            var result = await mediator.Send(command);
            return Ok(new { Data = result });
        }
    }
}
