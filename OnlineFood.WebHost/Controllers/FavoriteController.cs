using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Dtos.Favorites;
using OnlineFood.Application.Services.Favorites.Commands;
using OnlineFood.Application.Services.Favorites.Queries;

namespace OnlineFood.WebHost.Controllers;

[ApiController]
[Route("[controller]")]
public class FavoriteController : ControllerBase
{
    private readonly IFavoriteCommandService _FavoriteCommandService;
    private readonly IFavoriteQueryService _FavoriteQueryService;


    public FavoriteController(IFavoriteCommandService FavoriteCommandService, IFavoriteQueryService FavoriteQueryService)
    {
        _FavoriteCommandService = FavoriteCommandService;
        _FavoriteQueryService = FavoriteQueryService;
    }

    [HttpPost]
    public async Task<IActionResult> Create(FavoriteDto dto)
    {
        var result = await _FavoriteCommandService.Create(dto);
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> Update(FavoriteDto dto)
    {
        var result = await _FavoriteCommandService.Update(dto);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(FavoriteDto dto)
    {
        var result = await _FavoriteCommandService.Delete(dto);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> Get(int id)
    {
        var result = await _FavoriteQueryService.GetById(id);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _FavoriteQueryService.GetList();
        return Ok(result);
    }
}