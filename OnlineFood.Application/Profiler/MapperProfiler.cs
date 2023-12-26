using AutoMapper;
using OnlineFood.Application.Dtos.Users;
using OnlineFood.Application.Features.Addresses.Commands.Requests;
using OnlineFood.Application.Features.Comments.Commands.Requests;
using OnlineFood.Application.Features.Customers.Commands.Requests;
using OnlineFood.Application.Features.Favorites.Commands.Requests;
using OnlineFood.Application.Features.Messages.Commands.Requests;
using OnlineFood.Application.Features.Notifications.Commands.Requests;
using OnlineFood.Application.Features.OrderItems.Commands.Requests;
using OnlineFood.Application.Features.Orders.Commands.Requests;
using OnlineFood.Application.Features.Trancations.Commands.Requests;
using OnlineFood.Application.Features.Users.Commands.Requests;
using OnlineFood.Application.Features.Wallets.Commands.Requests;
using OnlineFood.Domain.Entities.Addresses;
using OnlineFood.Domain.Entities.Comments;
using OnlineFood.Domain.Entities.Customers;
using OnlineFood.Domain.Entities.Favorites;
using OnlineFood.Domain.Entities.Messages;
using OnlineFood.Domain.Entities.Notifications;
using OnlineFood.Domain.Entities.OrderItems;
using OnlineFood.Domain.Entities.Orders;
using OnlineFood.Domain.Entities.Trancations;
using OnlineFood.Domain.Entities.Users;
using OnlineFood.Domain.Entities.Wallets;

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


        CreateMap<Address, CreateAddressCommand>().ReverseMap();
        CreateMap<Address, UpdateAddressCommand>().ReverseMap();

        
        CreateMap<Message, CreateMessageCommand>().ReverseMap();
        CreateMap<Message, UpdateMessageCommand>().ReverseMap();

        
        CreateMap<Notification, CreateNotificationCommand>().ReverseMap();
        CreateMap<Notification, UpdateNotificationCommand>().ReverseMap();

        
        CreateMap<Wallet, CreateWalletCommand>().ReverseMap();
        CreateMap<Wallet, UpdateWalletCommand>().ReverseMap();


    }
}