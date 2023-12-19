using MediatR;
using OnlineFood.Application.Features.Trancations.Commands.Requests;
using OnlineFood.Domain.Entities.Trancations;
using OnlineFood.Domain.InterfaceRepositories.Trancations;

namespace OnlineFood.Application.Features.Trancations.Commands.RequestHandlers;

public class DeleteTrancationCommandHandler : IRequestHandler<DeleteTrancationCommand, bool>
{
	private readonly ITrancationRepository _TrancationRepository;	

	public DeleteTrancationCommandHandler(ITrancationRepository TrancationRepository)
	{
		this._TrancationRepository = TrancationRepository;
	}

	public Task<bool> Handle(DeleteTrancationCommand request, CancellationToken cancellationToken)
	{
		Trancation Trancation = new Trancation { Id = request.Id };
		return _TrancationRepository.Delete(Trancation);
	}
}
