using OnlineFood.Domain.Entities.Provinces;
using OnlineFood.Domain.IReaders.Provinces;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Readers.Provinces;

public class ProvinceReader : GenericReader<Province>, IProvinceReader
{
    public ProvinceReader(OnlineFoodDBConext dbContext) : base(dbContext)
    {
    }
}