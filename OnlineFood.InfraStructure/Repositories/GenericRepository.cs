using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using OnlineFood.Domain.InterfaceRepositories;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly OnlineFoodDBConext _dbContext;

    public GenericRepository(OnlineFoodDBConext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<T> Get(int id)
    {
        return await _dbContext.Set<T>().FindAsync(id);
    }

    public async Task<IReadOnlyList<T>> GetAll(Expression<Func<T, bool>>? whereVariable = null, string join = "")
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

    public async Task<T> Create(T entity)
    {
        await _dbContext.Set<T>().AddAsync(entity);
        await _dbContext.SaveChangesAsync();
        return entity;
    }

    public async Task<bool> Exist(int id)
    {
        var result = await Get(id);
        return result != null;
    }

    public async Task Update(T entity)
    {
        _dbContext.Entry(entity).State = EntityState.Modified;
        _dbContext.SaveChangesAsync();
    }

    public async Task Delete(T entity)
    {
        _dbContext.Set<T>().Remove(entity);
        _dbContext.SaveChangesAsync();
    }
}