using OnlineFood.Domain.IRepositories.WorkTimes;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Repositories.WorkTime;

public class WorkTimeRepository:GenericRepository<Domain.Entities.WorkTimes.WorkTime>,IWorkTimeRepository
{
    public WorkTimeRepository(OnlineFoodDBConext dbContext) : base(dbContext)
    {
    }
}