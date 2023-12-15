using MediatR;
using OnlineFood.Domain.Entities.Comments;

namespace OnlineFood.Application.Features.Comments.Queries.Requests;

public class GetListCommentsQuery : IRequest<List<Comment>>
{
}
