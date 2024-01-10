using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.AccountTransactions.Commands.Requests;
using OnlineFood.Domain.Entities.AccountTransactions;
using OnlineFood.Domain.IRepositories;

namespace OnlineFood.Application.Features.AccountTransactions.Commands.RequestHandlers;

public class CreateAccountTransactionCommandHandler : IRequestHandler<CreateAccountTransactionCommand, bool>
{
	private readonly IUnitOfWork _unitOfWork;
	private readonly IMapper _mapper;

	public CreateAccountTransactionCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
	{
		this._unitOfWork = unitOfWork;
		this._mapper = mapper;
	}

	public async Task<bool> Handle(CreateAccountTransactionCommand request, CancellationToken cancellationToken)
	{
		var entity = _mapper.Map<AccountTransaction>(request);
		var result = await _unitOfWork.GenericReposity<AccountTransaction>().Create(entity);
		return result;
	}
}
