using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using OnlineFood.Application.Services.Users.Commands;
using OnlineFood.Application.Services.Users.Queries;

namespace OnlineFood.Application;

public static class DIContainer
{
    public static IServiceCollection ApplicationServiceCollections(this IServiceCollection services)
    {
        services.AddScoped<IUserCommandService, UserCommandService>();
        services.AddScoped<IUserQueryService, UserQueryService>();

        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        return services;
    }
}