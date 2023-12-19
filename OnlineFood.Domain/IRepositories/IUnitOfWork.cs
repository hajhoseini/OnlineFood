using OnlineFood.Domain.Entities.Base;
using OnlineFood.Domain.InterfaceRepositories;

namespace OnlineFood.Domain.IRepositories;

public interface IUnitOfWork : IDisposable
{
	IGenericRepository<TEntity> GenericReposity<TEntity>() where TEntity : class;

	int Complete();
}
