using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Features.Messages.Queries.Requests;
using OnlineFood.Application.Features.RestaurantCategories.Queries.Requests;
using OnlineFood.Domain.Entities.RestaurantCategories;

namespace OnlineFood.WebHost.Controllers
{
    [Area("Admin")]
    public class ResturantCategoryController : Controller
    {
        private readonly IMediator mediator;

        public ResturantCategoryController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> GetListResturantCategories(GetListRestaurantCategoriesQuery query)
        {
            var result = await mediator.Send(query);
            return Ok(new { Data = result });
        }
    }
}
