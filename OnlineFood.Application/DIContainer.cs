using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace OnlineFood.Application;

public static class DIContainer
{
    public static IServiceCollection ApplicationServiceCollections(this IServiceCollection services)
    {        
        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        return services;
    }
}