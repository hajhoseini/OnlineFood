using MediatR;

namespace OnlineFood.Application.Features.Provinces.Commands.Requests;

public class UpdateProvinceCommand : IRequest<bool>
{
	public int Id { get; set; }
	public DateTime CreateDate { get; set; }
	public string Name { get; set; }

}
