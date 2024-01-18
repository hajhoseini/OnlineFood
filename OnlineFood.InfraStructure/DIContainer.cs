using Microsoft.Extensions.DependencyInjection;
using OnlineFood.Domain.InterfaceRepositories;
using OnlineFood.Domain.InterfaceRepositories.Addresses;
using OnlineFood.Domain.InterfaceRepositories.Cities;
using OnlineFood.Domain.InterfaceRepositories.Comments;
using OnlineFood.Domain.InterfaceRepositories.Customers;
using OnlineFood.Domain.InterfaceRepositories.Favorites;
using OnlineFood.Domain.InterfaceRepositories.MenuCategories;
using OnlineFood.Domain.InterfaceRepositories.Messages;
using OnlineFood.Domain.InterfaceRepositories.Notifications;
using OnlineFood.Domain.InterfaceRepositories.OrderItems;
using OnlineFood.Domain.InterfaceRepositories.Orders;
using OnlineFood.Domain.InterfaceRepositories.Provinces;
using OnlineFood.Domain.InterfaceRepositories.RestaurantCategories;
using OnlineFood.Domain.InterfaceRepositories.AccountTransactions;
using OnlineFood.Domain.InterfaceRepositories.Users;
using OnlineFood.Domain.InterfaceRepositories.Wallets;
using OnlineFood.Domain.IReaders;
using OnlineFood.Domain.IReaders.Addresses;
using OnlineFood.Domain.IReaders.Cities;
using OnlineFood.Domain.IReaders.Comments;
using OnlineFood.Domain.IReaders.Customers;
using OnlineFood.Domain.IReaders.Favorites;
using OnlineFood.Domain.IReaders.MenuCategories;
using OnlineFood.Domain.IReaders.MenuItems;
using OnlineFood.Domain.IReaders.Menus;
using OnlineFood.Domain.IReaders.Messages;
using OnlineFood.Domain.IReaders.Notifications;
using OnlineFood.Domain.IReaders.OrderItems;
using OnlineFood.Domain.IReaders.Orders;
using OnlineFood.Domain.IReaders.Provinces;
using OnlineFood.Domain.IReaders.RestaurantCategories;
using OnlineFood.Domain.IReaders.Restaurants;
using OnlineFood.Domain.IReaders.AccountTransactions;
using OnlineFood.Domain.IReaders.Users;
using OnlineFood.Domain.IReaders.Wallets;
using OnlineFood.Domain.IReaders.WorkTimes;
using OnlineFood.Domain.IRepositories;
using OnlineFood.Domain.IRepositories.MenuItems;
using OnlineFood.Domain.IRepositories.Menus;
using OnlineFood.Domain.IRepositories.Restaurants;
using OnlineFood.Domain.IRepositories.WorkTimes;
using OnlineFood.InfraStructure.Readers;
using OnlineFood.InfraStructure.Readers.Addresses;
using OnlineFood.InfraStructure.Readers.Comments;
using OnlineFood.InfraStructure.Readers.Customers;
using OnlineFood.InfraStructure.Readers.Favorites;
using OnlineFood.InfraStructure.Readers.IMenuItem;
using OnlineFood.InfraStructure.Readers.Menu;
using OnlineFood.InfraStructure.Readers.Messages;
using OnlineFood.InfraStructure.Readers.MenuCategories;
using OnlineFood.InfraStructure.Readers.Notifications;
using OnlineFood.InfraStructure.Readers.OrderItems;
using OnlineFood.InfraStructure.Readers.Orders;
using OnlineFood.InfraStructure.Readers.Provinces;
using OnlineFood.InfraStructure.Readers.Resturant;
using OnlineFood.InfraStructure.Readers.AccountTransactions;
using OnlineFood.InfraStructure.Readers.Users;
using OnlineFood.InfraStructure.Readers.Wallets;
using OnlineFood.InfraStructure.Repositories;
using OnlineFood.InfraStructure.Repositories.Addresses;
using OnlineFood.InfraStructure.Repositories.Cities;
using OnlineFood.InfraStructure.Repositories.Comments;
using OnlineFood.InfraStructure.Repositories.Customers;
using OnlineFood.InfraStructure.Repositories.Favorites;
using OnlineFood.InfraStructure.Repositories.Menu;
using OnlineFood.InfraStructure.Repositories.MenuCategories;
using OnlineFood.InfraStructure.Repositories.MenuItem;
using OnlineFood.InfraStructure.Repositories.Messages;
using OnlineFood.InfraStructure.Repositories.Notifications;
using OnlineFood.InfraStructure.Repositories.OrderItems;
using OnlineFood.InfraStructure.Repositories.Orders;
using OnlineFood.InfraStructure.Repositories.Provinces;
using OnlineFood.InfraStructure.Repositories.RestaurantCategories;
using OnlineFood.InfraStructure.Repositories.Resturant;
using OnlineFood.InfraStructure.Repositories.Users;
using OnlineFood.InfraStructure.Repositories.Wallets;
using OnlineFood.InfraStructure.Repositories.WorkTime;
using OnlineFood.InfraStructure.Repositories.AccountTransactions;
using OnlineFood.Domain.IReaders.SiteViewLogs;
using OnlineFood.Domain.IRepositories.SiteViewLogs;
using OnlineFood.InfraStructure.Readers.SiteViewLogs;
using OnlineFood.InfraStructure.Repositories.SiteViewLogs;
using OnlineFood.InfraStructure.Readers.WorkTime;

namespace OnlineFood.InfraStructure;

public static class DIContainer
{
    public static IServiceCollection InfraStructureServiceCollections(this IServiceCollection service)
    {
        service.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        service.AddScoped<IUserRepository, UserRepository>();
        service.AddScoped<ICommentRepository, CommentRepository>();
        service.AddScoped<ICustomerRepository, CustomerRepository>();
        service.AddScoped<IFavoriteRepository, FavoriteRepository>();
        service.AddScoped<IOrderItemRepository, OrderItemRepository>();
        service.AddScoped<IOrderRepository, OrderRepository>();
        service.AddScoped<IAccountTransactionRepository, AccountTransactionRepository>();
        service.AddScoped<IAddressRepository, AddressRepository>();
        service.AddScoped<IMessageRepository, MessageRepository>();
        service.AddScoped<INotificationRepository, NotificationRepository>();
        service.AddScoped<IWalletRepository, WalletRepository>();
        service.AddScoped<ICityRepository, CityRepository>();
        service.AddScoped<IProvinceRepository, ProvinceRepository>();
        service.AddScoped<IMenuCategoryRepository, MenuCategoryRepository>();
        service.AddScoped<IRestaurantCategoryRepository, RestaurantCategoryRepository>();

        service.AddScoped(typeof(IGenericReader<>), typeof(GenericReader<>));
        service.AddScoped<IUserReader, UserReader>();
        service.AddScoped<ICommentReader, CommentReader>();
        service.AddScoped<ICustomerReader, CustomerReader>();
        service.AddScoped<IFavoriteReader, FavoriteReader>();
        service.AddScoped<IOrderItemReader, OrderItemReader>();
        service.AddScoped<IOrderReader, OrderReader>();
        service.AddScoped<IAccountTransactionReader, AccountTransactionReader>();
        service.AddScoped<IAddressReader, AddressReader>();
        service.AddScoped<IMessageReader, MessageReader>();
        service.AddScoped<INotificationReader, NotificationReader>();
        service.AddScoped<IWalletReader, WalletReader>();
        service.AddScoped<ICityReader, CityReader>();
        service.AddScoped<IProvinceReader, ProvinceReader>();
        service.AddScoped<IMenuCategoryReader, MenuCategoryReader>();
        service.AddScoped<IRestaurantCategoryReader, RestaurantCategoryReader>();
        service.AddScoped<IWorkTimeReader, WorkTimeReader>();
        service.AddScoped<IWorkTimeRepository, WorkTimeRepository>();
        service.AddScoped<IRestaurantReader, RestaurantReader>();
        service.AddScoped<IRestaurantRepository, RestaurantRepository>();
        service.AddScoped<IMenuReader, MenuReader>();
        service.AddScoped<IMenuRepository, MenuRepository>();
        service.AddScoped<IMenuItemReader, MenuItemReader>();
        service.AddScoped<IMenuItemRepository, MenuItemRepository>();

        service.AddScoped<ISiteViewLogReader, SiteViewLogReader>();
        service.AddScoped<ISiteViewLogRepository, SiteViewLogRepository>();

        service.AddScoped<IUnitOfWork, UnitOfWork>();

        return service;
    }
}