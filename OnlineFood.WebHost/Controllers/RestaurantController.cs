using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineFood.Application.Features.Restaurants.Commands.Requests;
using System.Xml;

namespace OnlineFood.WebHost.Controllers
{
    public class RestaurantController : Controller
    {
        private IMediator mediator;
        private readonly IWebHostEnvironment env;
        public RestaurantController(IMediator mediator, IWebHostEnvironment env)
        {
            this.mediator = mediator;
            this.env = env;

        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(CreateRestaurantCommand command,IFormFile banner)
        {
            if (banner != null && banner.Length > 0)
            {
                // Process the uploaded file
                string fileName = Guid.NewGuid().ToString()+Path.GetExtension(banner.FileName);
                string filePath = Path.Combine(env.WebRootPath,@"images\restaurant");

                using (var stream = new FileStream(Path.Combine(filePath,fileName), FileMode.Create))
                {
                    banner.CopyTo(stream);
                }
                command.Banner = $@"\image\restaurant\{fileName}";
            }
            if (ModelState.IsValid)
            {
                await mediator.Send(command);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).Replace("Controller", ""));
            }
            return View(command);
        }
    }
}
