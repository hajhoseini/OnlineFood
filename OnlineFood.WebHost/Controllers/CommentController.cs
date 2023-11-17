using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Dtos.Comments;
using OnlineFood.Application.Services.Comments.Commands;
using OnlineFood.Application.Services.Comments.Queries;

namespace OnlineFood.WebHost.Controllers;

[ApiController]
[Route("[controller]")]
public class CommentController : ControllerBase
{
    private readonly ICommentCommandService _CommentCommandService;
    private readonly ICommentQueryService _CommentQueryService;


    public CommentController(ICommentCommandService CommentCommandService, ICommentQueryService CommentQueryService)
    {
        _CommentCommandService = CommentCommandService;
        _CommentQueryService = CommentQueryService;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CommentDto dto)
    {
        var result = await _CommentCommandService.Create(dto);
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> Update(CommentDto dto)
    {
        var result = await _CommentCommandService.Update(dto);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(CommentDto dto)
    {
        var result = await _CommentCommandService.Delete(dto);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> Get(int id)
    {
        var result = await _CommentQueryService.GetById(id);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _CommentQueryService.GetList();
        return Ok(result);
    }
}