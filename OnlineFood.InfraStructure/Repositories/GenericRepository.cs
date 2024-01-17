using Microsoft.EntityFrameworkCore;
using OnlineFood.Domain.InterfaceRepositories;
using OnlineFood.InfraStructure.DBContext;
using System.Reflection;

namespace OnlineFood.InfraStructure.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly OnlineFoodDBConext _dbContext;

    public GenericRepository(OnlineFoodDBConext dbContext)
    {
        _dbContext = dbContext;
    }       

    public async Task<bool> Create(T entity)
    {
        PropertyInfo propertyInfo = entity.GetType().GetProperty("CreateDate");
        if (propertyInfo != null)
        {
            propertyInfo.SetValue(entity, Convert.ChangeType(DateTime.Now, propertyInfo.PropertyType), null);
        }

        await _dbContext.Set<T>().AddAsync(entity);
        await _dbContext.SaveChangesAsync();
        return true;
    }    

    public async Task<bool> Update(T entity)
    {
        _dbContext.Entry(entity).State = EntityState.Modified;
        _dbContext.SaveChangesAsync();
        return true;
    }

    public async Task<bool> Delete(T entity)
    {
        _dbContext.Set<T>().Remove(entity);
        _dbContext.SaveChangesAsync();
        return true;
    }
}