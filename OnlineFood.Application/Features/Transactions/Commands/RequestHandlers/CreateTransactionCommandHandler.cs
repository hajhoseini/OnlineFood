using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.Transactions.Commands.Requests;
using OnlineFood.Domain.Entities.Transactions;
using OnlineFood.Domain.IRepositories;

namespace OnlineFood.Application.Features.Transactions.Commands.RequestHandlers;

public class CreateTransactionCommandHandler : IRequestHandler<CreateTransactionCommand, bool>
{
	private readonly IUnitOfWork _unitOfWork;
	private readonly IMapper _mapper;

	public CreateTransactionCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
	{
		this._unitOfWork = unitOfWork;
		this._mapper = mapper;
	}

	public async Task<bool> Handle(CreateTransactionCommand request, CancellationToken cancellationToken)
	{
		var entity = _mapper.Map<Transaction>(request);
		var result = await _unitOfWork.GenericReposity<Transaction>().Create(entity);
		return result;
	}
}
