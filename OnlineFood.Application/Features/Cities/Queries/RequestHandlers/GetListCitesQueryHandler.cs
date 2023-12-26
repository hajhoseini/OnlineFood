using MediatR;
using OnlineFood.Application.Features.Cities.Queries.Requests;
using OnlineFood.Domain.Entities.Cities;
using OnlineFood.Domain.IReaders.Cities;

namespace OnlineFood.Application.Features.Cities.Queries.RequestHandlers;

public class GetListCitiesQueryHandler : IRequestHandler<GetListCitesQuery, List<City>>
{
	private readonly ICityReader _CityReader;

	public GetListCitiesQueryHandler(ICityReader CityReader)
	{
		this._CityReader = CityReader;
	}

	public async Task<List<City>> Handle(GetListCitesQuery request, CancellationToken cancellationToken)
	{
		var all = await _CityReader.GetList(null, null);
		return all.ToList();
	}
}
