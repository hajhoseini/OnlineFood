using MediatR;

namespace OnlineFood.Application.Features.Addresses.Commands.Requests;

public class UpdateAddressCommand : IRequest<bool>
{
	public int Id { get; set; }
    public string Neighborhood { get; set; }
    public string Coordinate { get; set; }
}