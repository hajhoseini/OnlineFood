using MediatR;
using OnlineFood.Application.DTOs.Cities;

namespace OnlineFood.Application.Features.Cities.Queries.Requests;

public class GetCityQuery : IRequest<CityDTO>
{
	public int Id { get; set; }
}
