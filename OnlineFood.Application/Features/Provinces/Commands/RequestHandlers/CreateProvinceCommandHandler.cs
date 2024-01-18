using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.Provinces.Commands.Requests;
using OnlineFood.Domain.Entities.Provinces;
using OnlineFood.Domain.IRepositories;

namespace OnlineFood.Application.Features.Provinces.Commands.RequestHandlers;

public class CreateProvinceCommandHandler : IRequestHandler<CreateProvinceCommand, bool>
{
	private readonly IUnitOfWork _unitOfWork;
	private readonly IMapper _mapper;

	public CreateProvinceCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
	{
		_unitOfWork = unitOfWork;
		_mapper = mapper;
	}

	public async Task<bool> Handle(CreateProvinceCommand request, CancellationToken cancellationToken)
	{
		var entity = _mapper.Map<Province>(request);
		var result = await _unitOfWork.GenericReposity<Province>().Create(entity);
		return result;
	}
}
