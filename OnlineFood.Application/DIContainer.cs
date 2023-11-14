using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using OnlineFood.Application.Services.Users.Commands;

namespace OnlineFood.Application;

public static class DIContainer
{
    public static IServiceCollection ApplicationServiceCollections(this IServiceCollection services)
    {
        services.AddScoped<ICreateUserService, CreateUserService>();
        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        return services;
    }
}