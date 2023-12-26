using MediatR;

namespace OnlineFood.Application.Features.Cities.Commands.Requests;

public class DeleteCityCommand : IRequest<bool>
{
	public int Id { get; set; }
}
