using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.Comments.Commands.Requests;
using OnlineFood.Domain.Entities.Comments;
using OnlineFood.Domain.InterfaceRepositories.Comments;

namespace OnlineFood.Application.Features.Comments.Commands.RequestHandlers;

public class UpdateCommentCommandHandler : IRequestHandler<UpdateCommentCommand, bool>
{
	private readonly ICommentRepository _CommentRepository;
	private readonly IMapper _mapper;

	public UpdateCommentCommandHandler(ICommentRepository CommentRepository, IMapper mapper)
	{
		this._CommentRepository = CommentRepository;
		this._mapper = mapper;
	}

	public Task<bool> Handle(UpdateCommentCommand request, CancellationToken cancellationToken)
	{
		var entity = _mapper.Map<Comment>(request);
		return _CommentRepository.Update(entity);
	}
}
