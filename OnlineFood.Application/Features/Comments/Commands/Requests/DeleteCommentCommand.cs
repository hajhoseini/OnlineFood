using MediatR;

namespace OnlineFood.Application.Features.Comments.Commands.Requests;

public class DeleteCommentCommand : IRequest<bool>
{
	public int Id { get; set; }
}
