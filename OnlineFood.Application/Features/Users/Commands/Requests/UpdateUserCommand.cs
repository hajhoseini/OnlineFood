using MediatR;

namespace OnlineFood.Application.Features.Users.Commands.Requests;

public class UpdateUserCommand : IRequest<bool>
{
	public int Id { get; set; }
	public DateTime CreateDate { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string UserName { get; set; }
	public string Password { get; set; }
}
