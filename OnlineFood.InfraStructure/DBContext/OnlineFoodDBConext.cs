using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineFood.Domain.Entities.Addresses;
using OnlineFood.Domain.Entities.Cities;
using OnlineFood.Domain.Entities.Comments;
using OnlineFood.Domain.Entities.Customers;
using OnlineFood.Domain.Entities.Favorites;
using OnlineFood.Domain.Entities.MenuCategories;
using OnlineFood.Domain.Entities.MenuItems;
using OnlineFood.Domain.Entities.Menus;
using OnlineFood.Domain.Entities.Messages;
using OnlineFood.Domain.Entities.Notifications;
using OnlineFood.Domain.Entities.OrderItems;
using OnlineFood.Domain.Entities.Orders;
using OnlineFood.Domain.Entities.Provinces;
using OnlineFood.Domain.Entities.RestaurantCategories;
using OnlineFood.Domain.Entities.SocialMedias;
using OnlineFood.Domain.Entities.Users;
using OnlineFood.Domain.Entities.Wallets;
using OnlineFood.Domain.Entities.WorkTimes;

namespace OnlineFood.InfraStructure.DBContext;

public class OnlineFoodDBConext : IdentityDbContext<User,Role,string>
{
    public OnlineFoodDBConext(DbContextOptions<OnlineFoodDBConext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<User>()
            .Property(e => e.Id)
            .ValueGeneratedOnAdd();
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Role> Role { get; set; }
    public DbSet<Address> Address { get; set; }
    public DbSet<City> City { get; set; }
    public DbSet<Comment> Comment { get; set; }
    public DbSet<Customer> Customer { get; set; }
    public DbSet<Favorite> Favorite { get; set; }
    public DbSet<MenuCategory> MenuCategory { get; set; }
    public DbSet<MenuItem> MenuItem { get; set; }
    public DbSet<Menu> Menu { get; set; }
    public DbSet<Message> Message { get; set; }
    public DbSet<Notification> Notification { get; set; }
    public DbSet<OrderItem> OrderItem { get; set; }
    public DbSet<Order> Order { get; set; }
    public DbSet<Province> Province { get; set; }
    public DbSet<RestaurantCategory> RestaurantCategory { get; set; }
    //public DbSet<Restaurant> Restaurant { get; set; }
    public DbSet<SocialMedia> SocialMedia { get; set; }
    //public DbSet<Transaction> Transaction { get; set; }
    public DbSet<Wallet> Wallet { get; set; }
    public DbSet<WorkTime> WorkTime { get; set; }
}
