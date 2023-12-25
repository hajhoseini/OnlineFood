using MediatR;
using OnlineFood.Application.Features.MenuCategories.Queries.Requests;
using OnlineFood.Domain.Entities.MenuCategories;
using OnlineFood.Domain.IReaders.MenuCategories;

namespace OnlineFood.Application.Features.MenuCategories.Queries.RequestHandlers;

public class GetListMenuCategoriesQueryHandler : IRequestHandler<GetListMenuCategoriesQuery, List<MenuCategory>>
{
	private readonly IMenuCategoryReader _MenuCategoryReader;

	public GetListMenuCategoriesQueryHandler(IMenuCategoryReader MenuCategoryReader)
	{
		this._MenuCategoryReader = MenuCategoryReader;
	}

	public async Task<List<MenuCategory>> Handle(GetListMenuCategoriesQuery request, CancellationToken cancellationToken)
	{
		var all = await _MenuCategoryReader.GetList(null, null);
		return all.ToList();
	}
}
