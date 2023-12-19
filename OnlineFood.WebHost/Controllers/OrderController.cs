using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Features.Orders.Commands.Requests;
using OnlineFood.Application.Features.Orders.Queries.Requests;

namespace OnlineFood.WebHost.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
	private readonly IMediator mediator;

	public OrderController(IMediator mediator)
	{
		this.mediator = mediator;
	}

	[HttpGet]
	public async Task<IActionResult> GetListOrders([FromBody] GetListOrdersQuery query)
	{
		var result = await mediator.Send(query);
		return Ok(new { Data = result });
	}

	[HttpGet("{id}")]
	public async Task<IActionResult> GetOrderById(int id)
	{
		GetOrderQuery query = new GetOrderQuery() { Id = id };
		var result = await mediator.Send(query);
		return Ok(new { Data = result });
	}

	[HttpPost]
	public async Task<IActionResult> CreateOrder([FromBody] CreateOrderCommand command)
	{
		var result = await mediator.Send(command);
		return Ok(new { Data = result });
	}

	[HttpPut]
	public async Task<IActionResult> UpdateOrder([FromBody] UpdateOrderCommand command)
	{
		var result = await mediator.Send(command);
		return Ok(new { Data = result });
	}

	[HttpDelete]
	public async Task<IActionResult> DeleteOrder([FromBody] DeleteOrderCommand command)
	{
		var result = await mediator.Send(command);
		return Ok(new { Data = result });
	}
}