using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Features.RestaurantCategories.Commands.Requests;
using OnlineFood.Application.Features.RestaurantCategories.Queries.Requests;

namespace OnlineFood.WebHost.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize]
public class RestaurantCategoryController : Controller
{
    private readonly IMediator _mediator;

    public RestaurantCategoryController(IMediator mediator)
    {
        _mediator = mediator;
    }


    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var model = await _mediator.Send(new GetListRestaurantCategoriesQuery());
        return View(model);
    }

    [HttpGet]
    public async Task<IActionResult> New()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> New(CreateRestaurantCategoryCommand command)
    {
        bool result;
        if (ModelState.IsValid)
            result = await _mediator.Send(command);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> Edit(int id = 0)
    {
        if (id == 0)
            return RedirectToAction(nameof(Index));
        var model = await _mediator.Send(new GetRestaurantCategoryQuery() { Id = id });
        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateRestaurantCategoryCommand command)
    {
        bool result;
        if (ModelState.IsValid)
            result = await _mediator.Send(command);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> Delete(int id = 0)
    {
        if (id == 0)
            return RedirectToAction(nameof(Index));
        var model = await _mediator.Send(new GetRestaurantCategoryQuery() { Id = id });
        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Delete(DeleteRestaurantCategoryCommand command)
    {
        bool result;
        if (ModelState.IsValid)
            result = await _mediator.Send(command);
        return RedirectToAction(nameof(Index));
    }
}