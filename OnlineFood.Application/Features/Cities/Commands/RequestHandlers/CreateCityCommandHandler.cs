using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.Cities.Commands.Requests;
using OnlineFood.Domain.Entities.Cities;
using OnlineFood.Domain.IRepositories;

namespace OnlineFood.Application.Features.Cities.Commands.RequestHandlers;

public class CreateCityCommandHandler : IRequestHandler<CreateCityCommand, bool>
{
	private readonly IUnitOfWork _unitOfWork;
	private readonly IMapper _mapper;

	public CreateCityCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
	{
		this._unitOfWork = unitOfWork;
		this._mapper = mapper;
	}

	public async Task<bool> Handle(CreateCityCommand request, CancellationToken cancellationToken)
	{
		var entity = _mapper.Map<City>(request);
		var result = await _unitOfWork.GenericReposity<City>().Update(entity);
		return result;
	}
}
