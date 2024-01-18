using MediatR;
using OnlineFood.Application.Dtos.Cities;

namespace OnlineFood.Application.Features.Cities.Queries.Requests;

public class GetCityQuery : IRequest<CityDTO>
{
	public int Id { get; set; }
}
