namespace OnlineFood.Domain.InterfaceRepositories;

public interface IGenericRepository<T> where T : class
{    
    Task<bool> Create(T entity);    
    Task<bool> Update(T entity);
    Task<bool> Delete(T entity);
}