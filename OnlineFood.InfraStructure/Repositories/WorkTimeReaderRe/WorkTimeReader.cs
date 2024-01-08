using System.Linq.Expressions;
using OnlineFood.Domain.Entities.WorkTimes;
using OnlineFood.Domain.IReaders.WorkTimes;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Repositories.WorkTimeReaderRe;

public class WorkTimeReader:GenericRepository<WorkTime>,IWorkTimeReader
{
    public WorkTimeReader(OnlineFoodDBConext dbContext) : base(dbContext)
    {
    }

    public Task<WorkTime> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<WorkTime>> GetList(Expression<Func<WorkTime, bool>>? whereVariable = null, string join = "")
    {
        throw new NotImplementedException();
    }
}