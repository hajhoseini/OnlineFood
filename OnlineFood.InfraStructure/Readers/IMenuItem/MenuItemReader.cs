using OnlineFood.Domain.Entities.MenuItems;
using OnlineFood.Domain.IReaders.MenuItems;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Readers.IMenuItem;

public class MenuItemReader:GenericReader<MenuItem>,IMenuItemReader
{
    public MenuItemReader(OnlineFoodDBConext dbContext) : base(dbContext)
    {
    }
}