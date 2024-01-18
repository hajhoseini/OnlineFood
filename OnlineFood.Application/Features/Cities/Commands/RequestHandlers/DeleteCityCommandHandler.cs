using MediatR;
using OnlineFood.Application.Features.Cities.Commands.Requests;
using OnlineFood.Domain.Entities.Cities;
using OnlineFood.Domain.InterfaceRepositories.Cities;

namespace OnlineFood.Application.Features.Cities.Commands.RequestHandlers;

public class DeleteCityCommandHandler : IRequestHandler<DeleteCityCommand, bool>
{
	private readonly ICityRepository _CityRepository;

	public DeleteCityCommandHandler(ICityRepository CityRepository)
	{
		_CityRepository = CityRepository;
	}

	public Task<bool> Handle(DeleteCityCommand request, CancellationToken cancellationToken)
	{
		City city = new City { Id = request.Id };
		return _CityRepository.Delete(city);
	}
}