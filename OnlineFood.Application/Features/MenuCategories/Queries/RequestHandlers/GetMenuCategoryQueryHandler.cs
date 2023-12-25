using MediatR;
using OnlineFood.Application.Features.MenuCategories.Queries.Requests;
using OnlineFood.Domain.Entities.MenuCategories;
using OnlineFood.Domain.IReaders.MenuCategories;

namespace OnlineFood.Application.Features.MenuCategories.Queries.RequestHandlers;	

public class GetMenuCategoryQueryHandler : IRequestHandler<GetMenuCategoryQuery, MenuCategory>
{
	private readonly IMenuCategoryReader _MenuCategoryReader;

	public GetMenuCategoryQueryHandler(IMenuCategoryReader MenuCategoryReader)
	{
		this._MenuCategoryReader = MenuCategoryReader;
	}

	public async Task<MenuCategory> Handle(GetMenuCategoryQuery request, CancellationToken cancellationToken)
	{
		return await _MenuCategoryReader.GetById(request.Id);
	}
}
