using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.Users.Commands.Requests;
using OnlineFood.Domain.Entities.Users;
using OnlineFood.Domain.InterfaceRepositories.Users;

namespace OnlineFood.Application.Features.Users.Commands.RequestHandlers;

public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, bool>
{
	private readonly IUserRepository _userRepository;
	private readonly IMapper _mapper;

	public UpdateUserCommandHandler(IUserRepository userRepository, IMapper mapper)
	{
		this._userRepository = userRepository;
		this._mapper = mapper;
	}

	public Task<bool> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
	{
		var entity = _mapper.Map<User>(request);
		return _userRepository.Update(entity);
	}
}
