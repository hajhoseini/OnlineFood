using MediatR;
using OnlineFood.Application.Features.Provinces.Queries.Requests;
using OnlineFood.Application.Dtos.Province;
using OnlineFood.Domain.IReaders.Provinces;
using AutoMapper;

namespace OnlineFood.Application.Features.Provinces.Queries.RequestHandlers;

public class GetListProvincesQueryHandler : IRequestHandler<GetListProvincesQuery, List<ProvinceDTO>>
{
	private readonly IProvinceReader _ProvinceReader;
	private readonly IMapper _mapper;

	public GetListProvincesQueryHandler(IProvinceReader ProvinceReader, IMapper mapper)
	{
		_ProvinceReader = ProvinceReader;
		_mapper = mapper;
	}


	public async Task<List<ProvinceDTO>> Handle(GetListProvincesQuery request, CancellationToken cancellationToken)
	{
		var all = await _ProvinceReader.GetList(null);
		var result = new List<ProvinceDTO>();
		foreach (var item in all)
		{
			var province = _mapper.Map<ProvinceDTO>(item);
			result.Add(province);
		}
		return result;
	}
}