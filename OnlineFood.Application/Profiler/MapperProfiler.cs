using AutoMapper;
using OnlineFood.Application.Dtos.Users;
using OnlineFood.Application.Features.Cities.Commands.Requests;
using OnlineFood.Application.Features.Comments.Commands.Requests;
using OnlineFood.Application.Features.Customers.Commands.Requests;
using OnlineFood.Application.Features.Favorites.Commands.Requests;
using OnlineFood.Application.Features.MenuCategories.Commands.Requests;
using OnlineFood.Application.Features.OrderItems.Commands.Requests;
using OnlineFood.Application.Features.Orders.Commands.Requests;
using OnlineFood.Application.Features.Provinces.Commands.Requests;
using OnlineFood.Application.Features.RestaurantCategories.Commands.Requests;
using OnlineFood.Application.Features.Trancations.Commands.Requests;
using OnlineFood.Application.Features.Users.Commands.Requests;
using OnlineFood.Domain.Entities.Cities;
using OnlineFood.Domain.Entities.Comments;
using OnlineFood.Domain.Entities.Customers;
using OnlineFood.Domain.Entities.Favorites;
using OnlineFood.Domain.Entities.MenuCategories;
using OnlineFood.Domain.Entities.OrderItems;
using OnlineFood.Domain.Entities.Orders;
using OnlineFood.Domain.Entities.Provinces;
using OnlineFood.Domain.Entities.RestaurantCategories;
using OnlineFood.Domain.Entities.Trancations;
using OnlineFood.Domain.Entities.Users;

namespace OnlineFood.Application.Profiler;

public class MapperProfiler : Profile
{
    public MapperProfiler()
    {
        //CreateMap<User, UserDto>().ReverseMap();
        CreateMap<User, LoginDto>().ReverseMap();
        CreateMap<User, CreateUserCommand>().ReverseMap();
        CreateMap<User, UpdateUserCommand>().ReverseMap();

        CreateMap<Trancation, CreateTrancationCommand>().ReverseMap();
        CreateMap<Trancation, UpdateTrancationCommand>().ReverseMap();

        CreateMap<Comment, CreateCommentCommand>().ReverseMap();
        CreateMap<Comment, UpdateCommentCommand>().ReverseMap();

        CreateMap<Customer, CreateCustomerCommand>().ReverseMap();
        CreateMap<Customer, UpdateCustomerCommand>().ReverseMap();

        CreateMap<Favorite, CreateFavoriteCommand>().ReverseMap();
        CreateMap<Favorite, UpdateFavoriteCommand>().ReverseMap();

        CreateMap<OrderItem, CreateOrderItemCommand>().ReverseMap();
        CreateMap<OrderItem, UpdateOrderItemCommand>().ReverseMap();

        CreateMap<Order, CreateOrderCommand>().ReverseMap();
        CreateMap<Order, UpdateOrderCommand>().ReverseMap();

        CreateMap<MenuCategory, CreateMenuCategoryCommand>().ReverseMap();
        CreateMap<MenuCategory, UpdateMenuCategoryCommand>().ReverseMap();

        CreateMap<RestaurantCategory, CreateRestaurantCategoryCommand>().ReverseMap();
        CreateMap<RestaurantCategory, UpdateRestaurantCategoryCommand>().ReverseMap();

        CreateMap<City, CreateCityCommand>().ReverseMap();
        CreateMap<City, UpdateCityCommand>().ReverseMap();

        CreateMap<Province, CreateProvinceCommand>().ReverseMap();
        CreateMap<Province, UpdateProvinceCommand>().ReverseMap();
    }
}