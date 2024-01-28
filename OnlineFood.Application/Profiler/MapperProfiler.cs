using AutoMapper;
using OnlineFood.Application.Dtos.Message;
using OnlineFood.Application.Dtos.Users;
using OnlineFood.Application.Features.Addresses.Commands.Requests;
using OnlineFood.Application.Features.Cities.Commands.Requests;
using OnlineFood.Application.Features.Comments.Commands.Requests;
using OnlineFood.Application.Features.Customers.Commands.Requests;
using OnlineFood.Application.Features.Favorites.Commands.Requests;
using OnlineFood.Application.Features.MenuCategories.Commands.Requests;
using OnlineFood.Application.Features.Messages.Commands.Requests;
using OnlineFood.Application.Features.Notifications.Commands.Requests;
using OnlineFood.Application.Features.OrderItems.Commands.Requests;
using OnlineFood.Application.Features.Orders.Commands.Requests;
using OnlineFood.Application.Features.Provinces.Commands.Requests;
using OnlineFood.Application.Features.RestaurantCategories.Commands.Requests;
using OnlineFood.Application.Features.AccountTransactions.Commands.Requests;
using OnlineFood.Application.Features.Users.Commands.Requests;
using OnlineFood.Application.Features.Wallets.Commands.Requests;
using OnlineFood.Domain.Entities.Addresses;
using OnlineFood.Domain.Entities.Cities;
using OnlineFood.Domain.Entities.Comments;
using OnlineFood.Domain.Entities.Customers;
using OnlineFood.Domain.Entities.Favorites;
using OnlineFood.Domain.Entities.MenuCategories;
using OnlineFood.Domain.Entities.Messages;
using OnlineFood.Domain.Entities.Notifications;
using OnlineFood.Domain.Entities.OrderItems;
using OnlineFood.Domain.Entities.Orders;
using OnlineFood.Domain.Entities.Provinces;
using OnlineFood.Domain.Entities.RestaurantCategories;
using OnlineFood.Domain.Entities.AccountTransactions;
using OnlineFood.Domain.Entities.Users;
using OnlineFood.Domain.Entities.Wallets;
using OnlineFood.Domain.IReaders.SiteViewLogs;
using OnlineFood.Domain.Entities.SiteViewLogs;
using OnlineFood.Application.Features.SiteViewLogs.Commands.Requests;
using OnlineFood.Application.Dtos.RestaurantCategory;
using OnlineFood.Application.Dtos.Province;
using OnlineFood.Application.Dtos.Cities;
using OnlineFood.Application.Dtos.Customers;

namespace OnlineFood.Application.Profiler;

public class MapperProfiler : Profile
{
    public MapperProfiler()
    {
        //CreateMap<User, UserDto>().ReverseMap();
        CreateMap<User, LoginDto>().ReverseMap();
        CreateMap<User, CreateUserCommand>().ReverseMap();
        CreateMap<User, UpdateUserCommand>().ReverseMap();

        CreateMap<AccountTransaction, CreateAccountTransactionCommand>().ReverseMap();
        CreateMap<AccountTransaction, UpdateAccountTransactionCommand>().ReverseMap();

        CreateMap<Comment, CreateCommentCommand>().ReverseMap();
        CreateMap<Comment, UpdateCommentCommand>().ReverseMap();

        CreateMap<Customer, CreateCustomerCommand>().ReverseMap();
        CreateMap<Customer, UpdateCustomerCommand>().ReverseMap();
        CreateMap<Customer, CustomerDto>().ReverseMap();

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
        CreateMap<Message, MessageDTO>().ReverseMap();

        
        CreateMap<Notification, CreateNotificationCommand>().ReverseMap();
        CreateMap<Notification, UpdateNotificationCommand>().ReverseMap();

        
        CreateMap<Wallet, CreateWalletCommand>().ReverseMap();
        CreateMap<Wallet, UpdateWalletCommand>().ReverseMap();

        CreateMap<MenuCategory, CreateMenuCategoryCommand>().ReverseMap();
        CreateMap<MenuCategory, UpdateMenuCategoryCommand>().ReverseMap();

        CreateMap<RestaurantCategory, CreateRestaurantCategoryCommand>().ReverseMap();
        CreateMap<RestaurantCategory, UpdateRestaurantCategoryCommand>().ReverseMap();
        CreateMap<RestaurantCategory, RestaurantCategoryDTO>().ReverseMap();

        CreateMap<City, CreateCityCommand>().ReverseMap();
        CreateMap<City, UpdateCityCommand>().ReverseMap();
        CreateMap<City, CityDTO>().ReverseMap();

        CreateMap<Province, CreateProvinceCommand>().ReverseMap();
        CreateMap<Province, UpdateProvinceCommand>().ReverseMap();
        CreateMap<Province, ProvinceDTO>().ReverseMap();

        CreateMap<SiteViewLog, CreateSiteViewLogCommand>().ReverseMap();
    }
}