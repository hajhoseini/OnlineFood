using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineFood.Domain.Entities.Users;

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
}
