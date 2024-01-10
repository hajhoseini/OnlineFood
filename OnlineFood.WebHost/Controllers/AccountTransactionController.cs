using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Features.AccountTransactions.Commands.Requests;
using OnlineFood.Application.Features.AccountTransactions.Queries.Requests;

namespace OnlineFood.WebHost.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountTransactionController : ControllerBase
{
	private readonly IMediator mediator;

	public AccountTransactionController(IMediator mediator)
	{
		this.mediator = mediator;
	}

	[HttpGet]
	public async Task<IActionResult> GetListAccountTransactions([FromBody] GetListAccountTransactionsQuery query)
	{
		var result = await mediator.Send(query);
		return Ok(new { Data = result });
	}

	[HttpGet("{id}")]
	public async Task<IActionResult> GetAccountTransactionById(int id)
	{
		GetAccountTransactionQuery query = new GetAccountTransactionQuery() { Id = id };
		var result = await mediator.Send(query);
		return Ok(new { Data = result });
	}

	[HttpPost]
	public async Task<IActionResult> CreateTrancation([FromBody] CreateAccountTransactionCommand command)
	{
		var result = await mediator.Send(command);
		return Ok(new { Data = result });
	}

	[HttpPut]
	public async Task<IActionResult> UpdateTrancation([FromBody] UpdateAccountTransactionCommand command)
	{
		var result = await mediator.Send(command);
		return Ok(new { Data = result });
	}

	[HttpDelete]
	public async Task<IActionResult> DeleteTrancation([FromBody] DeleteAccountTransactionCommand command)
	{
		var result = await mediator.Send(command);
		return Ok(new { Data = result });
	}
}