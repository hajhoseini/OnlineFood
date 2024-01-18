using MediatR;
using OnlineFood.Application.Features.Provinces.Commands.Requests;
using OnlineFood.Domain.Entities.Provinces;
using OnlineFood.Domain.InterfaceRepositories.Provinces;

namespace OnlineFood.Application.Features.Provinces.Commands.RequestHandlers;

public class DeleteProvinceCommandHandler : IRequestHandler<DeleteProvinceCommand, bool>
{
	private readonly IProvinceRepository _ProvinceRepository;

	public DeleteProvinceCommandHandler(IProvinceRepository ProvinceRepository)
	{
		_ProvinceRepository = ProvinceRepository;
	}

	public Task<bool> Handle(DeleteProvinceCommand request, CancellationToken cancellationToken)
	{
		Province Province = new Province { Id = request.Id };
		return _ProvinceRepository.Delete(Province);
	}
}