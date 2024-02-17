using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Features.Customers.Queries.Requests;
using OnlineFood.WebHost.Models;
using System.Diagnostics;

namespace OnlineFood.WebHost.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMediator mediator;

        public HomeController(ILogger<HomeController> logger, IMediator mediator)
        {
            _logger = logger;            
            this.mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            GetCustomerQuery query = new GetCustomerQuery() { Id = 1 };
            var result = await mediator.Send(query);

            //ViewBag.FullName = result.FirstName + " " + result.LastName;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}