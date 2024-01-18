using AutoMapper;
using MediatR;
using OnlineFood.Application.Dtos.Cities;
using OnlineFood.Application.Features.Cities.Queries.Requests;
using OnlineFood.Domain.IReaders.Cities;

namespace OnlineFood.Application.Features.Cities.Queries.RequestHandlers;

public class GetCityQueryHandler : IRequestHandler<GetCityQuery, CityDTO>
{
    private readonly ICityReader _CityReader;
    private readonly IMapper _mapper;

    public GetCityQueryHandler(ICityReader CityReader, IMapper mapper)
    {
        _mapper = mapper;
        this._CityReader = CityReader;
    }


    public async Task<CityDTO> Handle(GetCityQuery request, CancellationToken cancellationToken)
    {
        var queryResult = await _CityReader.GetById(request.Id, "Province");
        CityDTO cityDTO = _mapper.Map<CityDTO>(queryResult);
        return cityDTO;
    }
}
