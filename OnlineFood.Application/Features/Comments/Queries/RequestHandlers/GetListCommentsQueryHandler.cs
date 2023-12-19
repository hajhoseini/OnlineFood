using MediatR;
using OnlineFood.Application.Features.Comments.Queries.Requests;
using OnlineFood.Domain.Entities.Comments;
using OnlineFood.Domain.IReaders.Comments;

namespace OnlineFood.Application.Features.Comments.Queries.RequestHandlers;

public class GetListCommentsQueryHandler : IRequestHandler<GetListCommentsQuery, List<Comment>>
{
	private readonly ICommentReader _CommentReader;

	public GetListCommentsQueryHandler(ICommentReader CommentReader)
	{
		this._CommentReader = CommentReader;
	}

	public async Task<List<Comment>> Handle(GetListCommentsQuery request, CancellationToken cancellationToken)
	{
		var all = await _CommentReader.GetList(null, null);
		return all.ToList();
	}
}
