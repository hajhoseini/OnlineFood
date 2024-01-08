using OnlineFood.Domain.Entities.WorkTimes;
using OnlineFood.Domain.IRepositories.WorkTimes;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Repositories.WorkTimeReaderRe;

public class WorkTimeRepository:GenericRepository<WorkTime>,IWorkTimeRepository
{
    public WorkTimeRepository(OnlineFoodDBConext dbContext) : base(dbContext)
    {
    }
}