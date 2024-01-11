using AutoMapper;
using OnlineFood.Domain.Entities.Base;
using OnlineFood.Domain.Entities.Users;
using OnlineFood.Domain.InterfaceRepositories;
using OnlineFood.Domain.IRepositories;
using OnlineFood.InfraStructure.DBContext;
using OnlineFood.InfraStructure.Repositories.Users;
using System.Collections;

namespace OnlineFood.InfraStructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
	private readonly OnlineFoodDBConext _context;
	private readonly IMapper _mapper;

	public UnitOfWork(OnlineFoodDBConext context, IMapper mapper)
	{
		_context = context;
		_mapper = mapper;
	}

	public int Complete()
	{
		return _context.SaveChanges();
	}

	public void Dispose()
	{
		_context.Dispose();
	}

	private Hashtable _repositories;
	private static readonly Dictionary<Type, Type> dic = new Dictionary<Type, Type>
	{
		{
			typeof(GenericRepository<User>), typeof(UserRepository)
		}
	};

	public IGenericRepository<TEntity> GenericReposity<TEntity>() where TEntity : class
	{
		if (_repositories == null)
		{
			_repositories = new Hashtable();
		}

		var type = typeof(TEntity).Name;
		if (_repositories.ContainsKey(type))
		{
			return (IGenericRepository<TEntity>)_repositories[type];
		}

		var closedRepositoryType = typeof(GenericRepository<>).MakeGenericType(typeof(TEntity));
		if (dic.ContainsKey(closedRepositoryType))
		{
			closedRepositoryType = dic[closedRepositoryType];
		}

		_repositories.Add(type, Activator.CreateInstance(closedRepositoryType, _context));

		return (IGenericRepository<TEntity>)_repositories[type];
	}
}
