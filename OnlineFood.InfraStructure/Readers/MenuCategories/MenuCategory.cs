using OnlineFood.Domain.Entities.MenuCategories;
using OnlineFood.Domain.IReaders.MenuCategories;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Readers.MenuCategories;

public class MenuCategoryReader : GenericReader<MenuCategory>, IMenuCategoryReader
{
    public MenuCategoryReader(OnlineFoodDBConext dbContext) : base(dbContext)
    {
    }
}