using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Features.Customers.Commands.Requests;
using OnlineFood.Application.Features.Customers.Queries.Requests;

namespace OnlineFood.WebHost.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : /*ControllerBase*/Controller
{
	private readonly IMediator mediator;

	public CustomerController(IMediator mediator)
	{
		this.mediator = mediator;
	}

	//[HttpGet]
	//public async Task<IActionResult> GetListCustomers([FromBody] GetListCustomersQuery query)
	//{
	//	var result = await mediator.Send(query);
	//	return Ok(new { Data = result });
	//}

    //[HttpGet("{id}")]
    //public async Task<IActionResult> GetCustomerById(int id)
    //{
    //	GetCustomerQuery query = new GetCustomerQuery() { Id = id };
    //	var result = await mediator.Send(query);
    //	return Ok(new { Data = result });
    //}
    [HttpGet]
    public async Task<IActionResult> GetCustomerById()
    {
		return View("Index");
    }

    [HttpPost]
	public async Task<IActionResult> CreateCustomer([FromBody] CreateCustomerCommand command)
	{
		var result = await mediator.Send(command);
		return Ok(new { Data = result });
	}

	[HttpPut]
	public async Task<IActionResult> UpdateCustomer([FromBody] UpdateCustomerCommand command)
	{
		var result = await mediator.Send(command);
		return Ok(new { Data = result });
	}

	[HttpDelete]
	public async Task<IActionResult> DeleteCustomer([FromBody] DeleteCustomerCommand command)
	{
		var result = await mediator.Send(command);
		return Ok(new { Data = result });
	}

	// public async Task<IActionResult> AddAddress(string customer)
	// {
	// 	return Microsoft.EntityFrameworkCore.Metadata.Internal.View
	// }
}