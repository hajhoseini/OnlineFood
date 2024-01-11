using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.SiteViewLogs.Commands.Requests;
using OnlineFood.Domain.Entities.SiteViewLogs;
using OnlineFood.Domain.IRepositories;

namespace OnlineFood.Application.Features.SiteViewLogs.Commands.RequestHandlers;

public class CreateSiteViewLogCommandHandler : IRequestHandler<CreateSiteViewLogCommand, bool>
{
	private readonly IUnitOfWork _unitOfWork;
	private readonly IMapper _mapper;

	public CreateSiteViewLogCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
	{
		this._unitOfWork = unitOfWork;
		this._mapper = mapper;
	}

	public async Task<bool> Handle(CreateSiteViewLogCommand request, CancellationToken cancellationToken)
	{
		var entity = _mapper.Map<SiteViewLog>(request);
		var result = await _unitOfWork.GenericReposity<SiteViewLog>().Create(entity);
		return result;
	}
}
