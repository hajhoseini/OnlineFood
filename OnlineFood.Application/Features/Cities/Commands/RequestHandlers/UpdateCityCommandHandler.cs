using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.Cities.Commands.Requests;
using OnlineFood.Domain.Entities.Cities;
using OnlineFood.Domain.InterfaceRepositories.Cities;

namespace OnlineFood.Application.Features.Cities.Commands.RequestHandlers;

public class UpdateCityCommandHandler : IRequestHandler<UpdateCityCommand, bool>
{
	private readonly ICityRepository _CityRepository;
	private readonly IMapper _mapper;

	public UpdateCityCommandHandler(ICityRepository CityRepository, IMapper mapper)
	{
		this._CityRepository = CityRepository;
		this._mapper = mapper;
	}

	public Task<bool> Handle(UpdateCityCommand request, CancellationToken cancellationToken)
	{
		var entity = _mapper.Map<City>(request);
		return _CityRepository.Update(entity);
	}
}
