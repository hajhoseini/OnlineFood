using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Features.Transactions.Commands.Requests;
using OnlineFood.Application.Features.Transactions.Queries.Requests;

namespace OnlineFood.WebHost.Controllers;

[ApiController]
[Route("[controller]")]
public class TrancationController : ControllerBase
{
	private readonly IMediator mediator;

	public TrancationController(IMediator mediator)
	{
		this.mediator = mediator;
	}

	[HttpGet]
	public async Task<IActionResult> GetListTransactions([FromBody] GetListTransactionsQuery query)
	{
		var result = await mediator.Send(query);
		return Ok(new { Data = result });
	}

	[HttpGet("{id}")]
	public async Task<IActionResult> GetTrancationById(int id)
	{
		GetTransactionQuery query = new GetTransactionQuery() { Id = id };
		var result = await mediator.Send(query);
		return Ok(new { Data = result });
	}

	[HttpPost]
	public async Task<IActionResult> CreateTrancation([FromBody] CreateTransactionCommand command)
	{
		var result = await mediator.Send(command);
		return Ok(new { Data = result });
	}

	[HttpPut]
	public async Task<IActionResult> UpdateTrancation([FromBody] UpdateTransactionCommand command)
	{
		var result = await mediator.Send(command);
		return Ok(new { Data = result });
	}

	[HttpDelete]
	public async Task<IActionResult> DeleteTrancation([FromBody] DeleteTransactionCommand command)
	{
		var result = await mediator.Send(command);
		return Ok(new { Data = result });
	}
}