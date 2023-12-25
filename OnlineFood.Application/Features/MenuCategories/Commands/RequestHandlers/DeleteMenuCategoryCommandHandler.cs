using MediatR;
using OnlineFood.Application.Features.MenuCategories.Commands.Requests;
using OnlineFood.Domain.Entities.MenuCategories;
using OnlineFood.Domain.InterfaceRepositories.MenuCategories;

namespace OnlineFood.Application.Features.MenuCategories.Commands.RequestHandlers;

public class DeleteMenuCategoryCommandHandler : IRequestHandler<DeleteMenuCategoryCommand, bool>
{
	private readonly IMenuCategoryRepository _MenuCategoryRepository;

	public DeleteMenuCategoryCommandHandler(IMenuCategoryRepository MenuCategoryRepository)
	{
		this._MenuCategoryRepository = MenuCategoryRepository;
	}

	public Task<bool> Handle(DeleteMenuCategoryCommand request, CancellationToken cancellationToken)
	{
        MenuCategory MenuCategory = new MenuCategory { Id = request.Id };
		return _MenuCategoryRepository.Delete(MenuCategory);
	}
}