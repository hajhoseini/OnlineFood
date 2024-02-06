using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Features.Users.Commands.Requests;
using OnlineFood.Application.Features.Users.Queries.Requests;

namespace OnlineFood.WebHost.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
	private readonly IMediator mediator;

	public UserController(IMediator mediator)
	{
		this.mediator = mediator;
	}

	[HttpGet]
	public async Task<IActionResult> GetListUsers([FromBody] GetListUsersQuery query)
	{
		var result = await mediator.Send(query);
		return Ok(new { Data = result });
	}

	[HttpGet("{id}")]
	public async Task<IActionResult> GetUserById(int id)
	{
		GetUserQuery query = new GetUserQuery() { Id = id };
		var result = await mediator.Send(query);
		return Ok(new { Data = result });
	}

	[HttpPost]
	public async Task<IActionResult> CreateUser([FromBody] CreateUserCommand command)
	{
		var result = await mediator.Send(command);
		return Ok(new { Data = result });
	}

	[HttpPut]
	public async Task<IActionResult> UpdateUser([FromBody] UpdateUserCommand command)
	{
		var result = await mediator.Send(command);
		return Ok(new { Data = result });
	}

	[HttpDelete]
	public async Task<IActionResult> DeleteUser([FromBody] DeleteUserCommand command)
	{
		var result = await mediator.Send(command);
		return Ok(new { Data = result });
	}
}