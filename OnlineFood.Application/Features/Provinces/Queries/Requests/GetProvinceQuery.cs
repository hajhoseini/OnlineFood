using MediatR;
using OnlineFood.Application.Dtos.Province;

namespace OnlineFood.Application.Features.Provinces.Queries.Requests;

public class GetProvinceQuery : IRequest<ProvinceDTO>
{
	public int Id { get; set; }
}
