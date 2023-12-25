using MediatR;

namespace OnlineFood.Application.Features.MenuCategories.Commands.Requests;

public class UpdateMenuCategoryCommand : IRequest<bool>
{
    public int Id { get; set; }
    public DateTime CreateDate { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}
