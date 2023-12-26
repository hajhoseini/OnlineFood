using MediatR;
using OnlineFood.Application.Features.Provinces.Queries.Requests;
using OnlineFood.Domain.Entities.Provinces;
using OnlineFood.Domain.IReaders.Provinces;

namespace OnlineFood.Application.Features.Provinces.Queries.RequestHandlers;

public class GetListProvincesQueryHandler : IRequestHandler<GetListProvincesQuery, List<Province>>
{
	private readonly IProvinceReader _ProvinceReader;

	public GetListProvincesQueryHandler(IProvinceReader ProvinceReader)
	{
		this._ProvinceReader = ProvinceReader;
	}

	public async Task<List<Province>> Handle(GetListProvincesQuery request, CancellationToken cancellationToken)
	{
		var all = await _ProvinceReader.GetList(null, null);
		return all.ToList();
	}
}
