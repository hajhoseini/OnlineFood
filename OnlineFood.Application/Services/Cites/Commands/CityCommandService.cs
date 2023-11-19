using AutoMapper;

using OnlineFood.Domain.Entities.City;
using OnlineFood.Domain.InterfaceRepositories.Comments;

namespace OnlineFood.Application.Services.Cites.Commands;

public class CityCommandService : ICityCommandService
{
    private readonly ICityRepository _CityRepository;
    private readonly IMapper _mapper;

    public CityCommandService(ICityRepository CityRepository, IMapper mapper)
    {
        _CityRepository = CityRepository;
        _mapper = mapper;
    }

    public async Task<bool> Create(City city)
    {
        var City = _mapper.Map<City>(city);
        return await _CityRepository.Create(City);
    }

    public async Task<bool> Delete(City city)
    {
        var City = _mapper.Map<City>(city);
        return await _CityRepository.Delete(City);
    }

    public async Task<bool> Update(City city)
    {
        var City = _mapper.Map<City>(city);
        return await _CityRepository.Update(City);
    }
}
