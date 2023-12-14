using MediatR;
using OnlineFood.Application.Features.Comments.Commands.Requests;
using OnlineFood.Domain.Entities.Comments;
using OnlineFood.Domain.InterfaceRepositories.Comments;

namespace OnlineFood.Application.Features.Comments.Commands.RequestHandlers;

public class DeleteCommentCommandHandler : IRequestHandler<DeleteCommentCommand, bool>
{
	private readonly ICommentRepository _CommentRepository;

	public DeleteCommentCommandHandler(ICommentRepository CommentRepository)
	{
		this._CommentRepository = CommentRepository;
	}

	public Task<bool> Handle(DeleteCommentCommand request, CancellationToken cancellationToken)
	{
		Comment Comment = new Comment { Id = request.Id };
		return _CommentRepository.Delete(Comment);
	}
}
