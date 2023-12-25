using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.MenuCategories.Commands.Requests;
using OnlineFood.Domain.Entities.MenuCategories;
using OnlineFood.Domain.InterfaceRepositories.MenuCategories;

namespace OnlineFood.Application.Features.MenuCategories.Commands.RequestHandlers;

public class UpdateMenuCategoryCommandHandler : IRequestHandler<UpdateMenuCategoryCommand, bool>
{
	private readonly IMenuCategoryRepository _MenuCategoryRepository;
	private readonly IMapper _mapper;

	public UpdateMenuCategoryCommandHandler(IMenuCategoryRepository MenuCategoryRepository, IMapper mapper)
	{
		this._MenuCategoryRepository = MenuCategoryRepository;
		this._mapper = mapper;
	}

	public Task<bool> Handle(UpdateMenuCategoryCommand request, CancellationToken cancellationToken)
	{
		var entity = _mapper.Map<MenuCategory>(request);
		return _MenuCategoryRepository.Update(entity);
	}
}
