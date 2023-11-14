using System.Linq.Expressions;

namespace OnlineFood.Domain.InterfaceRepositories;

public interface IGenericRepository<T> where T : class
{
    Task<T> Get(int id);
    Task<IReadOnlyList<T>> GetAll(Expression<Func<T, bool>>? whereVariable = null, string join = "");
    Task<T> Create(T entity);
    Task<bool> Exist(int id);
    Task Update(T entity);
    Task Delete(T entity);
}