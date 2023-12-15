using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Features.OrderItems.Commands.Requests;
using OnlineFood.Application.Features.OrderItems.Queries.Requests;

namespace OnlineFood.WebHost.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderItemController : ControllerBase
{
	private readonly IMediator mediator;

	public OrderItemController(IMediator mediator)
	{
		this.mediator = mediator;
	}

	[HttpGet]
	public async Task<IActionResult> GetListOrderItems([FromBody] GetListOrderItemsQuery query)
	{
		var result = await mediator.Send(query);
		return Ok(new { Data = result });
	}

	[HttpGet("{id}")]
	public async Task<IActionResult> GetOrderItemById(int id)
	{
		GetOrderItemQuery query = new GetOrderItemQuery() { Id = id };
		var result = await mediator.Send(query);
		return Ok(new { Data = result });
	}

	[HttpPost]
	public async Task<IActionResult> CreateOrderItem([FromBody] CreateOrderItemCommand command)
	{
		var result = await mediator.Send(command);
		return Ok(new { Data = result });
	}

	[HttpPut]
	public async Task<IActionResult> UpdateOrderItem([FromBody] UpdateOrderItemCommand command)
	{
		var result = await mediator.Send(command);
		return Ok(new { Data = result });
	}

	[HttpDelete]
	public async Task<IActionResult> DeleteOrderItem([FromBody] DeleteOrderItemCommand command)
	{
		var result = await mediator.Send(command);
		return Ok(new { Data = result });
	}
}