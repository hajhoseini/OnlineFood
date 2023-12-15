using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.Users.Commands.Requests;
using OnlineFood.Domain.Entities.Users;
using OnlineFood.Domain.InterfaceRepositories.Users;

namespace OnlineFood.Application.Features.Users.Commands.RequestHandlers;

public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, bool>
{
	private readonly IUserRepository _userRepository;
	private readonly IMapper _mapper;

	public DeleteUserCommandHandler(IUserRepository userRepository, IMapper mapper)
	{
		this._userRepository = userRepository;
		this._mapper = mapper;
	}

	public Task<bool> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
	{
		User user = new User { Id = request.Id };
		return _userRepository.Delete(user);
	}
}
