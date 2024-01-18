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
        public async Task<IActionResult> DisplayCategories()
        {
            var categories = await mediator.Send(new GetListRestaurantCategoriesQuery());
            return View(categories);
        }
    }
}
