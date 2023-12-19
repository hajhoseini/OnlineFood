using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Features.Favorites.Commands.Requests;
using OnlineFood.Application.Features.Favorites.Queries.Requests;

namespace OnlineFood.WebHost.Controllers;

[ApiController]
[Route("[controller]")]
public class FavoriteController : ControllerBase
{
	private readonly IMediator mediator;

	public FavoriteController(IMediator mediator)
	{
		this.mediator = mediator;
	}

	[HttpGet]
	public async Task<IActionResult> GetListFavorites([FromBody] GetListFavoritesQuery query)
	{
		var result = await mediator.Send(query);
		return Ok(new { Data = result });
	}

	[HttpGet("{id}")]
	public async Task<IActionResult> GetFavoriteById(int id)
	{
		GetFavoriteQuery query = new GetFavoriteQuery() { Id = id };
		var result = await mediator.Send(query);
		return Ok(new { Data = result });
	}

	[HttpPost]
	public async Task<IActionResult> CreateFavorite([FromBody] CreateFavoriteCommand command)
	{
		var result = await mediator.Send(command);
		return Ok(new { Data = result });
	}

	[HttpPut]
	public async Task<IActionResult> UpdateFavorite([FromBody] UpdateFavoriteCommand command)
	{
		var result = await mediator.Send(command);
		return Ok(new { Data = result });
	}

	[HttpDelete]
	public async Task<IActionResult> DeleteFavorite([FromBody] DeleteFavoriteCommand command)
	{
		var result = await mediator.Send(command);
		return Ok(new { Data = result });
	}
}