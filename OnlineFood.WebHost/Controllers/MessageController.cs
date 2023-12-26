using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Features.Messages.Queries.Requests;
using OnlineFood.Application.Features.Messages.Commands.Requests;

namespace OnlineFood.WebHost.Controllers;

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

    [HttpGet]
    public async Task<IActionResult> GetListMessages([FromBody] GetListMessagesQuery query)
    {
        var result = await mediator.Send(query);
        return Ok(new { Data = result });
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetMessageById(int id)
    {
        var query = new GetMessageQuery() { Id = id };
        var result = await mediator.Send(query);
        return Ok(new { Data = result });
    }

    [HttpPut]
    public async Task<IActionResult> UpdateMessage([FromBody] UpdateMessageCommand message)
    {
        var result = await mediator.Send(message);
        return Ok(new { Data = result });
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteMessage([FromBody] DeleteMessageCommand message)
    {
        var result = await mediator.Send(message);
        return Ok(new { Data = result });
    }
}