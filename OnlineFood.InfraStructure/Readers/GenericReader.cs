using Microsoft.EntityFrameworkCore;
using OnlineFood.Domain.IReaders;
using OnlineFood.InfraStructure.DBContext;
using System.Linq.Expressions;

namespace OnlineFood.InfraStructure.Readers;

public class GenericReader<T> : IGenericReader<T> where T : class
{
    private readonly OnlineFoodDBConext _dbContext;

    public GenericReader(OnlineFoodDBConext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<T> GetById(int id)
    {
        return await _dbContext.Set<T>().FindAsync(id);
    }

    public async Task<IReadOnlyList<T>> GetList(Expression<Func<T, bool>>? whereVariable = null, string join = "")
    {
        var all = _dbContext.Set<T>().AsQueryable();
        if (whereVariable != null)
        {
            all = all.Where(whereVariable);
        }

        if (join != "")
        {
            foreach (var j in join.Split(','))
            {
                all = all.Include(j);
            }
        }

        var result = await all.ToListAsync();
        return result;
    }
}
