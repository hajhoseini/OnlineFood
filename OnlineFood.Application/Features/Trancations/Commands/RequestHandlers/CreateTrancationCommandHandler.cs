using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.Trancations.Commands.Requests;
using OnlineFood.Domain.Entities.Trancations;
using OnlineFood.Domain.IRepositories;

namespace OnlineFood.Application.Features.Trancations.Commands.RequestHandlers;

public class CreateTrancationCommandHandler : IRequestHandler<CreateTrancationCommand, bool>
{
	private readonly IUnitOfWork _unitOfWork;
	private readonly IMapper _mapper;

	public CreateTrancationCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
	{
		this._unitOfWork = unitOfWork;
		this._mapper = mapper;
	}

	public async Task<bool> Handle(CreateTrancationCommand request, CancellationToken cancellationToken)
	{
		var entity = _mapper.Map<Trancation>(request);
		var result = await _unitOfWork.GenericReposity<Trancation>().Update(entity);
		return result;
	}
}
