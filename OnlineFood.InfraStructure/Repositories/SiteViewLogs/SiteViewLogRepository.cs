using OnlineFood.Domain.Entities.SiteViewLogs;
using OnlineFood.Domain.IRepositories.SiteViewLogs;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Repositories.SiteViewLogs;

public class SiteViewLogRepository : GenericRepository<SiteViewLog>, ISiteViewLogRepository
{
    public SiteViewLogRepository(OnlineFoodDBConext dbContext) : base(dbContext)
    {
    }
}