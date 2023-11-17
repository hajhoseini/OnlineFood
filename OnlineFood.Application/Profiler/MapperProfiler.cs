using AutoMapper;
using OnlineFood.Application.Dtos.Comments;
using OnlineFood.Application.Dtos.Customers;
using OnlineFood.Application.Dtos.Favorites;
using OnlineFood.Application.Dtos.OrderItems;
using OnlineFood.Application.Dtos.Orders;
using OnlineFood.Application.Dtos.Users;
using OnlineFood.Domain.Entities.Comments;
using OnlineFood.Domain.Entities.Customers;
using OnlineFood.Domain.Entities.Favorites;
using OnlineFood.Domain.Entities.OrderItems;
using OnlineFood.Domain.Entities.Orders;
using OnlineFood.Domain.Entities.Users;

namespace OnlineFood.Application.Profiler;

public class Mapperprofiler : Profile
{
    public Mapperprofiler()
    {
        CreateMap<User, UserDto>().ReverseMap();
        CreateMap<Comment, CommentDto>().ReverseMap();
        CreateMap<Customer, CustomerDto>().ReverseMap();
        CreateMap<Favorite, FavoriteDto>().ReverseMap();
        CreateMap<OrderItem, OrderItemDto>().ReverseMap();
        CreateMap<Order, OrderDto>().ReverseMap();
    }
}