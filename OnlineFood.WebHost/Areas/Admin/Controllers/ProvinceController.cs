using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Features.Provinces.Commands.Requests;
using OnlineFood.Application.Features.Provinces.Queries.Requests;

namespace OnlineFood.WebHost.Areas.Admin.Controllers;

[Authorize]
[Area("Admin")]
public class ProvinceController : Controller
{
    private readonly IMediator _mediator;

    public ProvinceController(IMediator mediator)
    {
            _mediator=mediator;
    }


    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var model = await _mediator.Send(new GetListProvincesQuery());
        return View(model);
    }

    [HttpGet]
    public async Task<IActionResult> New()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> New(CreateProvinceCommand command)
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
        var model = await _mediator.Send(new GetProvinceQuery() { Id = id });
        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateProvinceCommand command)
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
        var model = await _mediator.Send(new GetProvinceQuery() { Id = id });
        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Delete(DeleteProvinceCommand command)
    {
        bool result;
        if (ModelState.IsValid)
            result = await _mediator.Send(command);
        return RedirectToAction(nameof(Index));
    }
}
