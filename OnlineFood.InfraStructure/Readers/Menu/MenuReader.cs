using OnlineFood.Domain.IReaders.Menus;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Readers.Menu;

public class MenuReader:GenericReader<Domain.Entities.Menus.Menu>,IMenuReader
{
    public MenuReader(OnlineFoodDBConext dbContext) : base(dbContext)
    {
    }
}