using OnlineFood.Domain.IRepositories.MenuItems;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Repositories.MenuItem;

public class MenuItemRepository:GenericRepository<Domain.Entities.MenuItems.MenuItem>,IMenuItemRepository
{
    public MenuItemRepository(OnlineFoodDBConext dbContext) : base(dbContext)
    {
    }
}