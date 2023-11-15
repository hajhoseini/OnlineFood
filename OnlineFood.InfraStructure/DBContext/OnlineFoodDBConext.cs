using Microsoft.EntityFrameworkCore;
using OnlineFood.Domain.Entities.Users;

namespace OnlineFood.InfraStructure.DBContext;

public class OnlineFoodDBConext : DbContext
{
    public OnlineFoodDBConext(DbContextOptions<OnlineFoodDBConext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
}
