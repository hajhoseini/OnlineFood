using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.AccountTransactions.Commands.Requests;
using OnlineFood.Domain.Entities.AccountTransactions;
using OnlineFood.Domain.InterfaceRepositories.AccountTransactions;

namespace OnlineFood.Application.Features.AccountTransactions.Commands.RequestHandlers;

public class UpdateAccountTransactionCommandHandler : IRequestHandler<UpdateAccountTransactionCommand, bool>
{
	private readonly IAccountTransactionRepository _AccountTransactionRepository;
	private readonly IMapper _mapper;

	public UpdateAccountTransactionCommandHandler(IAccountTransactionRepository AccountTransactionRepository, IMapper mapper)
	{
		_AccountTransactionRepository = AccountTransactionRepository;
		_mapper = mapper;
	}

	public Task<bool> Handle(UpdateAccountTransactionCommand request, CancellationToken cancellationToken)
	{
		var entity = _mapper.Map<AccountTransaction>(request);
		return _AccountTransactionRepository.Update(entity);
	}
}
