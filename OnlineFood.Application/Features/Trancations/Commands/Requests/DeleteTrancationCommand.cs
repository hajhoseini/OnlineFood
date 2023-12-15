using MediatR;

namespace OnlineFood.Application.Features.Trancations.Commands.Requests;

public class DeleteTrancationCommand : IRequest<bool>
{
	public int Id { get; set; }
}
