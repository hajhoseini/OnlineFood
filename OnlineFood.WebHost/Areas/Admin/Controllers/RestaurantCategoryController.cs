using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Features.RestaurantCategories.Commands.Requests;
using OnlineFood.Application.Dtos.RestaurantCategory;

namespace OnlineFood.WebHost.Areas.Admin.Controllers;

[Area("Admin")]
public class RestaurantCategoryController : Controller
{
    private readonly IMediator _mediator;

    public RestaurantCategoryController(IMediator mediator)
    {
        _mediator = mediator;
    }


    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult New()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> New(CreateRestaurantCategoryCommand dto)
    {
        //dto.Id = 1;
        dto.CreateDate = DateTime.Now;
        var result = await _mediator.Send(dto);
        return Ok(result);
        //return RedirectToAction("Index", "RestaurantCategory");
    }
}