using AutoMapper;
using MediatR;
using OnlineFood.Application.DTOs.Province;
using OnlineFood.Application.Features.Provinces.Queries.Requests;
using OnlineFood.Domain.IReaders.Provinces;

namespace OnlineFood.Application.Features.Provinces.Queries.RequestHandlers;

public class GetProvinceQueryHandler : IRequestHandler<GetProvinceQuery, ProvinceDTO>
{
	private readonly IProvinceReader _ProvinceReader;
	private readonly IMapper _mapper;

	public GetProvinceQueryHandler(IProvinceReader ProvinceReader, IMapper mapper)
	{
		_ProvinceReader = ProvinceReader;
		_mapper = mapper;
	}


	public async Task<ProvinceDTO> Handle(GetProvinceQuery request, CancellationToken cancellationToken)
	{
		var queryResult = await _ProvinceReader.GetById(request.Id);
		ProvinceDTO result=_mapper.Map<ProvinceDTO>(queryResult);
		return result;
	}
}
