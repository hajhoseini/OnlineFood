using MediatR;
using OnlineFood.Application.Features.Comments.Queries.Requests;
using OnlineFood.Domain.Entities.Comments;
using OnlineFood.Domain.IReaders.Comments;

namespace OnlineFood.Application.Features.Comments.Queries.RequestHandlers;

public class GetCommentQueryHandler : IRequestHandler<GetCommentQuery, Comment>
{
	private readonly ICommentReader _CommentReader;

	public GetCommentQueryHandler(ICommentReader CommentReader)
	{
		this._CommentReader = CommentReader;
	}

	public async Task<Comment> Handle(GetCommentQuery request, CancellationToken cancellationToken)
	{
		return await _CommentReader.GetById(request.Id);
	}
}
