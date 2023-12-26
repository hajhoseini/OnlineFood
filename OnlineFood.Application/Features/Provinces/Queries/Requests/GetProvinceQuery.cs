using MediatR;
using OnlineFood.Domain.Entities.Provinces;

namespace OnlineFood.Application.Features.Provinces.Queries.Requests;

public class GetProvinceQuery : IRequest<Province>
{
	public int Id { get; set; }
}
