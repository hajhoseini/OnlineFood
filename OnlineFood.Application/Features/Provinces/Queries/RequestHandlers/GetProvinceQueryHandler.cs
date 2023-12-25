using MediatR;
using OnlineFood.Application.Features.Provinces.Queries.Requests;
using OnlineFood.Domain.Entities.Provinces;
using OnlineFood.Domain.IReaders.Provinces;

namespace OnlineFood.Application.Features.Provinces.Queries.RequestHandlers;

public class GetProvinceQueryHandler : IRequestHandler<GetProvinceQuery, Province>
{
	private readonly IProvinceReader _ProvinceReader;

	public GetProvinceQueryHandler(IProvinceReader ProvinceReader)
	{
		this._ProvinceReader = ProvinceReader;
	}

	public async Task<Province> Handle(GetProvinceQuery request, CancellationToken cancellationToken)
	{
		return await _ProvinceReader.GetById(request.Id);
	}
}
