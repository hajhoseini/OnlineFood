using AutoMapper;
using OnlineFood.Application.Dtos.Comments;
using OnlineFood.Application.Dtos.Customers;
using OnlineFood.Application.Dtos.Favorites;
using OnlineFood.Application.Dtos.OrderItems;
using OnlineFood.Application.Dtos.Orders;
using OnlineFood.Application.Features.Trancations.Commands.Requests;
using OnlineFood.Application.Features.Users.Commands.Requests;
using OnlineFood.Domain.Entities.Comments;
using OnlineFood.Domain.Entities.Customers;
using OnlineFood.Domain.Entities.Favorites;
using OnlineFood.Domain.Entities.OrderItems;
using OnlineFood.Domain.Entities.Orders;
using OnlineFood.Domain.Entities.Trancations;
using OnlineFood.Domain.Entities.Users;

namespace OnlineFood.Application.Profiler;

public class MapperProfiler : Profile
{
    public MapperProfiler()
    {
		CreateMap<User, CreateUserCommand>().ReverseMap();
		CreateMap<User, UpdateUserCommand>().ReverseMap();

		CreateMap<Trancation, CreateTrancationCommand>().ReverseMap();
		CreateMap<Trancation, UpdateTrancationCommand>().ReverseMap();

		CreateMap<Comment, CommentDto>().ReverseMap();
        CreateMap<Customer, CustomerDto>().ReverseMap();
        CreateMap<Favorite, FavoriteDto>().ReverseMap();
        CreateMap<OrderItem, OrderItemDto>().ReverseMap();
        CreateMap<Order, OrderDto>().ReverseMap();
    }
}