using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Dtos.Address;
using OnlineFood.Application.Features.Addresses.Queries.Requests;
using OnlineFood.Application.Features.Addresses.Commands.Requests;
using OnlineFood.Application.Features.UserAdderss.Command.Request;
using OnlineFood.Domain.Entities.Users;

namespace OnlineFood.WebHost.Controllers;

public class AddressController : Controller
{
    private readonly IMediator mediator;
    private readonly UserManager<User> _userManager;

    public AddressController(IMediator mediator, UserManager<User> userManager)
    {
        this.mediator = mediator;
        _userManager = userManager;
    }

    //
    // [HttpPost]
    // public async Task<IActionResult> CreateAddress([FromBody] CreateAddressCommand address)
    // {
    //     var result = await mediator.Send(address);
    //     return Ok(new { Data = result });
    // }
    //
    // [HttpGet]
    // public async Task<IActionResult> GetListAddresses([FromBody] GetListAddressesQuery query)
    // {
    //     var result = await mediator.Send(query);
    //     return Ok(new { Data = result });
    // }
    //
    // [HttpGet("{id}")]
    // public async Task<IActionResult> GetAddressById(int id)
    // {
    //     var query = new GetAddressQuery() { Id = id };
    //     var result = await mediator.Send(query);
    //     return Ok(new { Data = result });
    // }
    //
    // [HttpPut]
    // public async Task<IActionResult> UpdateAddress([FromBody] UpdateAddressCommand address)
    // {
    //     var result = await mediator.Send(address);
    //     return Ok(new { Data = result });
    // }
    //
    // [HttpDelete]
    // public async Task<IActionResult> DeleteAddress([FromBody] DeleteAddressCommand address)
    // {
    //     var result = await mediator.Send(address);
    //     return Ok(new { Data = result });
    // }
    [HttpGet]
    public async Task<IActionResult> index()
    {
        var test = new CreateAdderss();
        return View(test);
    }

    [HttpPost]
    public async Task<IActionResult> create(string address, string sakhteman, string pelak, string loc)
    {
        var result = await mediator.Send(new CreateAddressCommand()
            {
                Coordinate = loc,
                Neighborhood = address + "-" + sakhteman + "-" + pelak
            }
        );
        if (result != null)
        {
            var username = User.Identity.Name;
            var userid = _userManager.FindByNameAsync(username).Id;
            var adduseradderss = await mediator.Send(new AddAdressToUser()
            {
                addressid = result,
                userid = userid
            });
            if (adduseradderss == true)
            {
                ViewBag.Message = "عملیات انجام شده است";
                return RedirectToAction("index");
            }
            else
            {
                ViewBag.Message = "عملیات شکست خورد";
                return View("index");
            }
        }

        ViewBag.Message = "عملیات با شکست مواجه شده است";
        return View("index");
    }
}