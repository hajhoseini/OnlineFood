using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Dtos.Customers;
using OnlineFood.Application.Services.Customers.Commands;
using OnlineFood.Application.Services.Customers.Queries;

namespace OnlineFood.WebHost.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    private readonly ICustomerCommandService _CustomerCommandService;
    private readonly ICustomerQueryService _CustomerQueryService;


    public CustomerController(ICustomerCommandService CustomerCommandService, ICustomerQueryService CustomerQueryService)
    {
        _CustomerCommandService = CustomerCommandService;
        _CustomerQueryService = CustomerQueryService;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CustomerDto dto)
    {
        var result = await _CustomerCommandService.Create(dto);
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> Update(CustomerDto dto)
    {
        var result = await _CustomerCommandService.Update(dto);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(CustomerDto dto)
    {
        var result = await _CustomerCommandService.Delete(dto);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> Get(int id)
    {
        var result = await _CustomerQueryService.GetById(id);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _CustomerQueryService.GetList();
        return Ok(result);
    }
}