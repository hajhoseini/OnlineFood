using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.Trancations.Commands.Requests;
using OnlineFood.Domain.Entities.Trancations;
using OnlineFood.Domain.InterfaceRepositories.Trancations;

namespace OnlineFood.Application.Features.Trancations.Commands.RequestHandlers;

public class UpdateTrancationCommandHandler : IRequestHandler<UpdateTrancationCommand, bool>
{
	private readonly ITrancationRepository _TrancationRepository;
	private readonly IMapper _mapper;

	public UpdateTrancationCommandHandler(ITrancationRepository TrancationRepository, IMapper mapper)
	{
		this._TrancationRepository = TrancationRepository;
		this._mapper = mapper;
	}

	public Task<bool> Handle(UpdateTrancationCommand request, CancellationToken cancellationToken)
	{
		var entity = _mapper.Map<Trancation>(request);
		return _TrancationRepository.Update(entity);
	}
}
