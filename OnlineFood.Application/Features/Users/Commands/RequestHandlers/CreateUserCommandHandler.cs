using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.Users.Commands.Requests;
using OnlineFood.Domain.Entities.Users;
using OnlineFood.Domain.IRepositories;

namespace OnlineFood.Application.Features.Users.Commands.RequestHandlers;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, bool>
{
	private readonly IUnitOfWork _unitOfWork;
	private readonly IMapper _mapper;

	public CreateUserCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
	{
		this._unitOfWork = unitOfWork;
		this._mapper = mapper;
	}

	public async Task<bool> Handle(CreateUserCommand request, CancellationToken cancellationToken)
	{
		var entity = _mapper.Map<User>(request);
		var result = await _unitOfWork.GenericReposity<User>().Update(entity);
		return result;
	}
}
