using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Features.Messages.Commands.Requests;

namespace OnlineFood.WebHost.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        private readonly IMediator mediator;

        public MessageController(IMediator mediator)
        {
            this.mediator = mediator;
        }


        [HttpPost]
        public async Task<IActionResult> CreateMessage([FromBody] CreateMessageCommand message)
        {
            var result = await mediator.Send(message);
            return Ok(new { Data = result });
        }
    }
}
