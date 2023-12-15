using MediatR;
using OnlineFood.Domain.Entities.Comments;

namespace OnlineFood.Application.Features.Comments.Queries.Requests;

public class GetCommentQuery : IRequest<Comment>
{
	public int Id { get; set; }
}
