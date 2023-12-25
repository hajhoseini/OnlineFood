using MediatR;
using OnlineFood.Application.Features.Cities.Queries.Requests;
using OnlineFood.Domain.Entities.Cities;
using OnlineFood.Domain.IReaders.Cities;

namespace OnlineFood.Application.Features.Cities.Queries.RequestHandlers;

public class GetCityQueryHandler : IRequestHandler<GetCityQuery, City>
{
	private readonly ICityReader _CityReader;

	public GetCityQueryHandler(ICityReader CityReader)
	{
		this._CityReader = CityReader;
	}

	public async Task<City> Handle(GetCityQuery request, CancellationToken cancellationToken)
	{
		return await _CityReader.GetById(request.Id);
	}
}
