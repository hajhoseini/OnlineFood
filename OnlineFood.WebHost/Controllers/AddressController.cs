using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Features.Addresses.Queries.Requests;
using OnlineFood.Application.Features.Addresses.Commands.Requests;

namespace OnlineFood.WebHost.Controllers;

[ApiController]
[Route("[controller]")]
public class AddressController : ControllerBase
{
    private readonly IMediator mediator;

    public AddressController(IMediator mediator)
    {
        this.mediator = mediator;
    }


    [HttpPost]
    public async Task<IActionResult> CreateAddress([FromBody] CreateAddressCommand address)
    {
        var result = await mediator.Send(address);
        return Ok(new { Data = result });
    }

    [HttpGet]
    public async Task<IActionResult> GetListAddresses([FromBody] GetListAddressesQuery query)
    {
        var result = await mediator.Send(query);
        return Ok(new { Data = result });
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAddressById(int id)
    {
        var query = new GetAddressQuery() { Id = id };
        var result = await mediator.Send(query);
        return Ok(new { Data = result });
    }

    [HttpPut]
    public async Task<IActionResult> UpdateAddress([FromBody] UpdateAddressCommand address)
    {
        var result = await mediator.Send(address);
        return Ok(new { Data = result });
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteAddress([FromBody] DeleteAddressCommand address)
    {
        var result = await mediator.Send(address);
        return Ok(new { Data = result });
    }
}