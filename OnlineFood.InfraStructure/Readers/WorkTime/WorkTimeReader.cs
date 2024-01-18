using OnlineFood.Domain.IReaders.WorkTimes;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Readers.WorkTime;

public class WorkTimeReader:GenericReader<Domain.Entities.WorkTimes.WorkTime>,IWorkTimeReader
{
    public WorkTimeReader(OnlineFoodDBConext dbContext) : base(dbContext)
    {
    }
}