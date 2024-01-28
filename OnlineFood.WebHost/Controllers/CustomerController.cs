using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.DTOs.Customers;
using OnlineFood.Application.Features.Customers.Commands.Requests;
using OnlineFood.Application.Features.Customers.Queries.Requests;

namespace OnlineFood.WebHost.Controllers;

public class CustomerController : Controller
{
    private readonly IMediator mediator;

    public CustomerController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Edit(int id)
    {
        GetCustomerQuery query = new GetCustomerQuery() { Id = id };
        var result = await mediator.Send(query);
        return View(result);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(int id, CustomerDTO dto)
    {
        UpdateCustomerCommand command = new UpdateCustomerCommand { customer = dto };
        var result = await mediator.Send(command);
        return Ok(new { Data = result });
    }
}