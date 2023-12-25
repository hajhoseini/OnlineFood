using MediatR;
using OnlineFood.Domain.Entities.MenuCategories;
 
namespace OnlineFood.Application.Features.MenuCategories.Queries.Requests;

public class GetListMenuCategoriesQuery : IRequest<List<MenuCategory>>
{
}
