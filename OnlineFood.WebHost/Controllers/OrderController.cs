using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Dtos.Orders;
using OnlineFood.Application.Services.Orders.Commands;
using OnlineFood.Application.Services.Orders.Queries;

namespace OnlineFood.WebHost.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
    private readonly IOrderCommandService _OrderCommandService;
    private readonly IOrderQueryService _OrderQueryService;


    public OrderController(IOrderCommandService OrderCommandService, IOrderQueryService OrderQueryService)
    {
        _OrderCommandService = OrderCommandService;
        _OrderQueryService = OrderQueryService;
    }

    [HttpPost]
    public async Task<IActionResult> Create(OrderDto dto)
    {
        var result = await _OrderCommandService.Create(dto);
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> Update(OrderDto dto)
    {
        var result = await _OrderCommandService.Update(dto);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(OrderDto dto)
    {
        var result = await _OrderCommandService.Delete(dto);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> Get(int id)
    {
        var result = await _OrderQueryService.GetById(id);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _OrderQueryService.GetList();
        return Ok(result);
    }
}