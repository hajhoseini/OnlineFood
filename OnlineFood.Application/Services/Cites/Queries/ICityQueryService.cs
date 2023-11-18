using OnlineFood.Domain.Entities.City;
using System.Linq.Expressions;

namespace OnlineFood.Application.Services.Citys.Queries;

public interface ICityQueryService
{
    Task<City> GetById(int id);
    Task<List<City>> GetList(Expression<Func<City, bool>>? whereVariable = null, string join = "");
}
