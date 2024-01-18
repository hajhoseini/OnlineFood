using MediatR;

namespace OnlineFood.Application.Features.Cities.Commands.Requests;

public class UpdateCityCommand : IRequest<bool>
{
    public int Id { get; set; }
    public DateTime CreateDate { get; set; }
    public string Name { get; set; }
    public int ProvinceId { get; set; }
}
