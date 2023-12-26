using OnlineFood.Domain.Entities.MenuCategories;
using OnlineFood.Domain.InterfaceRepositories.MenuCategories;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Repositories.MenuCategories;

public class MenuCategoryRepository : GenericRepository<MenuCategory>, IMenuCategoryRepository
{
	public MenuCategoryRepository(OnlineFoodDBConext dbContext) : base(dbContext)
	{
	}
}