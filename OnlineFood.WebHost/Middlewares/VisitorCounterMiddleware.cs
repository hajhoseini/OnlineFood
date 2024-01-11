using OnlineFood.Domain.Entities.SiteViewLogs;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.WebHost.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class VisitorCounterMiddleware
    {
        private readonly RequestDelegate _next;
        //private readonly OnlineFoodDBConext _dbContext;

        public VisitorCounterMiddleware(RequestDelegate next/*, OnlineFoodDBConext dbContext*/)
        {
            //_dbContext = dbContext;
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            //if (!httpContext.Request.Path.ToString().ToLower().Contains("/admin"))
            //{
            //    var userInfo = httpContext.Request.Headers["User-Agent"];
            //    string ip = httpContext.Connection.RemoteIpAddress.ToString();

            //    //    CreateSiteViewLogCommand command = new()
            //    //    { CreateDate = DateTime.Now, IP = ip, Browser = "" };
            //    //    var result = await mediator.Send(command);
            //    //}           

            //    SiteViewLog siteViewLog = new() { CreateDate = DateTime.Now, IP = ip, Browser = "" };

            //    await _dbContext.AddAsync(siteViewLog);
            //    await _dbContext.SaveChangesAsync();

            //    await _next(httpContext);
            //}
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
