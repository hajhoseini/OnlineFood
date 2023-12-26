using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Features.Notifications.Queries.Requests;
using OnlineFood.Application.Features.Notifications.Commands.Requests;

namespace OnlineFood.WebHost.Controllers;

[ApiController]
[Route("[controller]")]
public class NotificationController : ControllerBase
{
    private readonly IMediator mediator;

    public NotificationController(IMediator mediator)
    {
        this.mediator = mediator;
    }


    [HttpPost]
    public async Task<IActionResult> CreateNotification([FromBody] CreateNotificationCommand Notification)
    {
        var result = await mediator.Send(Notification);
        return Ok(new { Data = result });
    }

    [HttpGet]
    public async Task<IActionResult> GetListNotifications([FromBody] GetListNotificationsQuery query)
    {
        var result = await mediator.Send(query);
        return Ok(new { Data = result });
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetNotificationById(int id)
    {
        var query = new GetNotificationQuery() { Id = id };
        var result = await mediator.Send(query);
        return Ok(new { Data = result });
    }

    [HttpPut]
    public async Task<IActionResult> UpdateNotification([FromBody] UpdateNotificationCommand Notification)
    {
        var result = await mediator.Send(Notification);
        return Ok(new { Data = result });
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteNotification([FromBody] DeleteNotificationCommand Notification)
    {
        var result = await mediator.Send(Notification);
        return Ok(new { Data = result });
    }
}