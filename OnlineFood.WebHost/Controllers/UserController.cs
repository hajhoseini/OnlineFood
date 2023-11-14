using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Services.Users.Commands;

namespace OnlineFood.WebHost.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly ICreateUserService _createUserService;

    public UserController(ICreateUserService createUserServic)
    {
        _createUserService = createUserServic;
    }

    [HttpPost]
    public async Task<IActionResult> AddUser(CreateUserRequestDto dto)
    {
        var result = await _createUserService.Execute(dto);
        return Ok(result);
    }
}