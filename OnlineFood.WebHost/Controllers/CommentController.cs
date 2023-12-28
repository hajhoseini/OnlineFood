using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Features.Comments.Commands.Requests;
using OnlineFood.Application.Features.Comments.Queries.Requests;

namespace OnlineFood.WebHost.Controllers;

[ApiController]
[Route("[controller]")]
public class CommentController : ControllerBase
{
	private readonly IMediator mediator;

	public CommentController(IMediator mediator)
	{
		this.mediator = mediator;
	}


	[HttpGet]
	public async Task<IActionResult> GetListComments([FromBody] GetListCommentsQuery query)
	{
		var result = await mediator.Send(query);
		return Ok(new { Data = result });
	}

	[HttpGet("{id}")]
	public async Task<IActionResult> GetCommentById(int id)
	{
		GetCommentQuery query = new GetCommentQuery() { Id = id };
		var result = await mediator.Send(query);
		return Ok(new { Data = result });
	}

	[HttpPost]
	public async Task<IActionResult> CreateComment([FromBody] CreateCommentCommand command)
	{
		var result = await mediator.Send(command);
		return Ok(new { Data = result });
	}

	[HttpPut]
	public async Task<IActionResult> UpdateComment([FromBody] UpdateCommentCommand command)
	{
		var result = await mediator.Send(command);
		return Ok(new { Data = result });
	}

	[HttpDelete]
	public async Task<IActionResult> DeleteComment([FromBody] DeleteCommentCommand command)
	{
		var result = await mediator.Send(command);
		return Ok(new { Data = result });
	}
}