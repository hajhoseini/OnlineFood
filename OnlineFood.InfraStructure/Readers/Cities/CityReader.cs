using OnlineFood.Domain.Entities.Cities;
using OnlineFood.Domain.IReaders.Cities;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Readers.Orders;

public class CityReader : GenericReader<City>, ICityReader
{
    public CityReader(OnlineFoodDBConext dbContext) : base(dbContext)
    {
    }
}