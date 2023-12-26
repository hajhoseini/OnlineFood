using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Features.Wallets.Queries.Requests;
using OnlineFood.Application.Features.Wallets.Commands.Requests;

namespace OnlineFood.WebHost.Controllers;

[ApiController]
[Route("[controller]")]
public class WalletController : ControllerBase
{
    private readonly IMediator mediator;

    public WalletController(IMediator mediator)
    {
        this.mediator = mediator;
    }


    [HttpPost]
    public async Task<IActionResult> CreateWallet([FromBody] CreateWalletCommand wallet)
    {
        var result = await mediator.Send(wallet);
        return Ok(new { Data = result });
    }

    [HttpGet]
    public async Task<IActionResult> GetListWallets([FromBody] GetListWalletsQuery query)
    {
        var result = await mediator.Send(query);
        return Ok(new { Data = result });
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetWalletById(int id)
    {
        var query = new GetWalletQuery() { Id = id };
        var result = await mediator.Send(query);
        return Ok(new { Data = result });
    }

    [HttpPut]
    public async Task<IActionResult> UpdateWallet([FromBody] UpdateWalletCommand wallet)
    {
        var result = await mediator.Send(wallet);
        return Ok(new { Data = result });
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteWallet([FromBody] DeleteWalletCommand wallet)
    {
        var result = await mediator.Send(wallet);
        return Ok(new { Data = result });
    }
}