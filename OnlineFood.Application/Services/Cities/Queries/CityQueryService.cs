using OnlineFood.Domain.Entities.Cities;
using OnlineFood.Domain.IReaders.Cities;
using System.Linq.Expressions;

namespace OnlineFood.Application.Services.Cities.Queries;

public class CityQueryService : ICityQueryService
{
    private readonly ICityReader _CityReader;

    public CityQueryService(ICityReader CityReader)
    {
        _CityReader = CityReader;
    }

    public async Task<City> GetById(int id)
    {
        return await _CityReader.GetById(id);
    }

    public async Task<List<City>> GetList(Expression<Func<City, bool>>? whereVariable = null, string join = "")
    {
        var all = await _CityReader.GetList();
        return all.ToList();
    }
}
