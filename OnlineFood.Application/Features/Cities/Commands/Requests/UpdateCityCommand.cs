using MediatR;

namespace OnlineFood.Application.Features.Cities.Commands.Requests;

public class UpdateCityCommand : IRequest<bool>
{
    public string Name { get; set; }
    public long ProvinceId { get; set; }
}
