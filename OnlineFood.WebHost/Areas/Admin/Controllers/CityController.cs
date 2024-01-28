using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.DTOs.Cities;
using OnlineFood.Application.Features.Cities.Commands.Requests;
using OnlineFood.Application.Features.Cities.Queries.Requests;
using OnlineFood.Application.Features.Provinces.Queries.Requests;

namespace OnlineFood.WebHost.Areas.Admin.Controllers;

[Authorize]
[Area("Admin")]
public class CityController : Controller
{
    private readonly IMediator _mediator;

    public CityController(IMediator mediator)
    {
        _mediator = mediator;
    }


    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var model = await _mediator.Send(new GetListCitesQuery());
        return View(model);
    }

    [HttpGet]
    public async Task<IActionResult> New(int ProvinceId = 0)
    {
        if (ProvinceId == 0)
            return RedirectToAction(nameof(Index));
        var province = await _mediator.Send(new GetProvinceQuery() { Id = ProvinceId });
        var model = new CityDTO();
        model.Province = province;
        model.ProvinceId= ProvinceId;
        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> New(CreateCityCommand command)
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
        var model = await _mediator.Send(new GetCityQuery() { Id = id });
        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCityCommand command)
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
        var model = await _mediator.Send(new GetCityQuery() { Id = id });
        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Delete(DeleteCityCommand command)
    {
        bool result;
        if (ModelState.IsValid)
            result = await _mediator.Send(command);
        return RedirectToAction(nameof(Index));
    }
}
