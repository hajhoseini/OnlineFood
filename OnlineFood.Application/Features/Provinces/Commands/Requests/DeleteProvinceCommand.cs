using MediatR;

namespace OnlineFood.Application.Features.Provinces.Commands.Requests;

public class DeleteProvinceCommand : IRequest<bool>
{
	public int Id { get; set; }
}
