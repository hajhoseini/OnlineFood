using OnlineFood.Domain.IRepositories.Menus;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Repositories.Menu;

public class MenuRepository:GenericRepository<Domain.Entities.Menus.Menu>,IMenuRepository
{
    public MenuRepository(OnlineFoodDBConext dbContext) : base(dbContext)
    {
    }
}