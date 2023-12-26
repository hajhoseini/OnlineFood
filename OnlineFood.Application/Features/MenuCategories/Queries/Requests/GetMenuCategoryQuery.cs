using MediatR;
using OnlineFood.Domain.Entities.MenuCategories;

namespace OnlineFood.Application.Features.MenuCategories.Queries.Requests;

public class GetMenuCategoryQuery : IRequest<MenuCategory>
{
	public int Id { get; set; }
}
