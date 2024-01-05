using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using OnlineFood.Application.Services.Users.Commands;

namespace OnlineFood.Application;

public static class DIContainer
{
    public static IServiceCollection ApplicationServiceCollections(this IServiceCollection services)
    {
        services.AddScoped<IUserCommandService, UserCommandService>();

        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(Assembly.GetExecutingAssembly());
        return services;
    }
}