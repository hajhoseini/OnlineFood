using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Features.RestaurantCategories.Commands.Requests;
using OnlineFood.Application.Dtos.RestaurantCategory;
using OnlineFood.Application.Features.RestaurantCategories.Queries.Requests;

namespace OnlineFood.WebHost.Areas.Admin.Controllers;

[Area("Admin")]
public class RestaurantCategoryController : Controller
{
    private readonly IMediator mediator;

    public RestaurantCategoryController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var categories = await mediator.Send(new ListRestaurantCategoriesQuery());
        return View(categories);
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
        var result = await mediator.Send(dto);
        return Ok(result);
        //return RedirectToAction("Index", "RestaurantCategory");
    }
}