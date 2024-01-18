using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.Provinces.Commands.Requests;
using OnlineFood.Domain.Entities.Provinces;
using OnlineFood.Domain.InterfaceRepositories.Provinces;

namespace OnlineFood.Application.Features.Provinces.Commands.RequestHandlers;

public class UpdateProvinceCommandHandler : IRequestHandler<UpdateProvinceCommand, bool>
{
	private readonly IProvinceRepository _ProvinceRepository;
	private readonly IMapper _mapper;

	public UpdateProvinceCommandHandler(IProvinceRepository ProvinceRepository, IMapper mapper)
	{
		_ProvinceRepository = ProvinceRepository;
		_mapper = mapper;
	}

	public Task<bool> Handle(UpdateProvinceCommand request, CancellationToken cancellationToken)
	{
		var entity = _mapper.Map<Province>(request);
		return _ProvinceRepository.Update(entity);
	}
}
