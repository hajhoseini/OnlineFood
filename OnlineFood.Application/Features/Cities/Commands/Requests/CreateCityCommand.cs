using MediatR;

namespace OnlineFood.Application.Features.Cities.Commands.Requests;

public class CreateCityCommand : IRequest<bool>
{
    public int Id { get; set; }
    public DateTime CreateDate { get; set; }
    public string Name { get; set; }
    public long ProvinceId { get; set; }
}
