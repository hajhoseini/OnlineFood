using MediatR;

namespace OnlineFood.Application.Features.MenuCategories.Commands.Requests;

public class DeleteMenuCategoryCommand : IRequest<bool>
{
	public int Id { get; set; }
}
