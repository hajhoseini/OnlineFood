using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Dtos.Users;
using OnlineFood.Application.Services.Users.Commands;
using OnlineFood.Application.Services.Users.Queries;

namespace OnlineFood.WebHost.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserCommandService _userCommandService;
    private readonly IUserQueryService _userQueryService;


    public UserController(IUserCommandService userCommandService, IUserQueryService userQueryService)
    {
        _userCommandService = userCommandService;
        _userQueryService = userQueryService;
    }

    [HttpPost]
    public async Task<IActionResult> Create(UserDto dto)
    {
        var result = await _userCommandService.Create(dto);
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> Update(UserDto dto)
    {
        var result = await _userCommandService.Update(dto);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(UserDto dto)
    {
        var result = await _userCommandService.Delete(dto);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> Get(int id)
    {
        var result = await _userQueryService.GetById(id);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _userQueryService.GetList();
        return Ok(result);
    }
}