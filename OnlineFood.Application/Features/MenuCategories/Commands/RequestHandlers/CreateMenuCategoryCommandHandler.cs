using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.MenuCategories.Commands.Requests;
using OnlineFood.Domain.Entities.MenuCategories;
using OnlineFood.Domain.IRepositories;

namespace OnlineFood.Application.Features.MenuCategories.Commands.RequestHandlers;

public class CreateMenuCategoryCommandHandler : IRequestHandler<CreateMenuCategoryCommand, bool>
{
	private readonly IUnitOfWork _unitOfWork;
	private readonly IMapper _mapper;

	public CreateMenuCategoryCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
	{
		this._unitOfWork = unitOfWork;
		this._mapper = mapper;
	}

	public async Task<bool> Handle(CreateMenuCategoryCommand request, CancellationToken cancellationToken)
	{
		var entity = _mapper.Map<MenuCategory>(request);
		var result = await _unitOfWork.GenericReposity<MenuCategory>().Update(entity);
		return result;
	}
}
