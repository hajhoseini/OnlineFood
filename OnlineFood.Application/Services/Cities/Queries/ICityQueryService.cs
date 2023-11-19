using OnlineFood.Domain.Entities.Cities;
using System.Linq.Expressions;

namespace OnlineFood.Application.Services.Cities.Queries;

public interface ICityQueryService
{
    Task<City> GetById(int id);
    Task<List<City>> GetList(Expression<Func<City, bool>>? whereVariable = null, string join = "");
}
