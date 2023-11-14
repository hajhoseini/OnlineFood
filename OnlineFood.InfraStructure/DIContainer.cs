using Microsoft.Extensions.DependencyInjection;
using OnlineFood.Domain.InterfaceRepositories;
using OnlineFood.Domain.InterfaceRepositories.Users;
using OnlineFood.InfraStructure.Repositories;
using OnlineFood.InfraStructure.Repositories.Users;

namespace OnlineFood.InfraStructure;

public static class DIContainer
{
    public static IServiceCollection InfraStructureServiceCollections(this IServiceCollection service)
    {
        service.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        service.AddScoped<IUserRepository, UserRepository>();
        return service;
    }
}