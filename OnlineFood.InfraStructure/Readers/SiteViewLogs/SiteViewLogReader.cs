using OnlineFood.Domain.Entities.SiteViewLogs;
using OnlineFood.Domain.IReaders.SiteViewLogs;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Readers.SiteViewLogs;

public class SiteViewLogReader : GenericReader<SiteViewLog>, ISiteViewLogReader
{
    public SiteViewLogReader(OnlineFoodDBConext dbContext) : base(dbContext)
    {
    }
}