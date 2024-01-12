using MediatR;
using OnlineFood.Application.Features.SiteViewLogs.Commands.Requests;

namespace OnlineFood.WebHost.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class VisitorCounterMiddleware
    {
        private readonly RequestDelegate _next;
        private IMediator _mediator;

        public VisitorCounterMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext, IMediator mediator)
        {
            string path = httpContext.Request.Path.ToString().ToLower();
            if (!path.Contains("/admin") && !path.Contains("/restaurant"))
            {
                _mediator = mediator;

                string browser = httpContext.Request.Headers["User-Agent"];
                string ip = httpContext.Connection.RemoteIpAddress.ToString();

                CreateSiteViewLogCommand command = new()
                                            { CreateDate = DateTime.Now, 
                                                IP = ip, 
                                                Browser = (browser != null ? browser : "") };

                var result = await mediator.Send(command);
            }

            await _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class VisitorCounterMiddlewareExtensions
    {
        public static IApplicationBuilder UseVisitorCounterMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<VisitorCounterMiddleware>();
        }
    }
}
