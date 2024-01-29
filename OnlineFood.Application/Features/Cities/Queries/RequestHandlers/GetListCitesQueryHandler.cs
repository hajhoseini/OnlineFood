using AutoMapper;
using MediatR;
using OnlineFood.Application.DTOs.Cities;
using OnlineFood.Application.Features.Cities.Queries.Requests;
using OnlineFood.Domain.IReaders.Cities;

namespace OnlineFood.Application.Features.Cities.Queries.RequestHandlers;

public class GetListCitiesQueryHandler : IRequestHandler<GetListCitesQuery, List<CityDTO>>
{
    private readonly ICityReader _CityReader;
    private readonly IMapper _mapper;

    public GetListCitiesQueryHandler(ICityReader CityReader, IMapper mapper)
    {
        _CityReader = CityReader;
        _mapper = mapper;
    }


    public async Task<List<CityDTO>> Handle(GetListCitesQuery request, CancellationToken cancellationToken)
    {
        var all = await _CityReader.GetList(null, "Province");
        var result = new List<CityDTO>();
        foreach (var item in all)
        {
            var city = _mapper.Map<CityDTO>(item);
            result.Add(city);
        }
        return result;
    }
}
