using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.Transactions.Commands.Requests;
using OnlineFood.Domain.Entities.Transactions;
using OnlineFood.Domain.InterfaceRepositories.Transactions;

namespace OnlineFood.Application.Features.Transactions.Commands.RequestHandlers;

public class UpdateTrancationCommandHandler : IRequestHandler<UpdateTransactionCommand, bool>
{
	private readonly ITransactionRepository _TransactionRepository;
	private readonly IMapper _mapper;

	public UpdateTrancationCommandHandler(ITransactionRepository TransactionRepository, IMapper mapper)
	{
		_TransactionRepository = TransactionRepository;
		_mapper = mapper;
	}

	public Task<bool> Handle(UpdateTransactionCommand request, CancellationToken cancellationToken)
	{
		var entity = _mapper.Map<Transaction>(request);
		return _TransactionRepository.Update(entity);
	}
}
