using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using OnlineFood.Application.Services.Comments.Commands;
using OnlineFood.Application.Services.Comments.Queries;
using OnlineFood.Application.Services.Customers.Commands;
using OnlineFood.Application.Services.Customers.Queries;
using OnlineFood.Application.Services.Favorites.Commands;
using OnlineFood.Application.Services.Favorites.Queries;
using OnlineFood.Application.Services.OrderItems.Commands;
using OnlineFood.Application.Services.OrderItems.Queries;
using OnlineFood.Application.Services.Orders.Commands;
using OnlineFood.Application.Services.Orders.Queries;
using OnlineFood.Application.Services.Users.Commands;
using OnlineFood.Application.Services.Users.Queries;

namespace OnlineFood.Application;

public static class DIContainer
{
    public static IServiceCollection ApplicationServiceCollections(this IServiceCollection services)
    {
        services.AddScoped<IUserCommandService, UserCommandService>();
        services.AddScoped<IUserQueryService, UserQueryService>();

        services.AddScoped<ICommentCommandService, CommentCommandService>();
        services.AddScoped<ICommentQueryService, CommentQueryService>();

        services.AddScoped<ICustomerCommandService, CustomerCommandService>();
        services.AddScoped<ICustomerQueryService, CustomerQueryService>();

        services.AddScoped<IFavoriteCommandService, FavoriteCommandService>();
        services.AddScoped<IFavoriteQueryService, FavoriteQueryService>();

        services.AddScoped<IOrderItemCommandService, OrderItemCommandService>();
        services.AddScoped<IOrderItemQueryService, OrderItemQueryService>();

        services.AddScoped<IOrderCommandService, OrderCommandService>();
        services.AddScoped<IOrderQueryService, OrderQueryService>();

        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        return services;
    }
}