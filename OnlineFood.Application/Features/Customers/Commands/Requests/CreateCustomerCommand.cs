using MediatR;
using OnlineFood.Common.Enums;

namespace OnlineFood.Application.Features.Customers.Commands.Requests;

public class CreateCustomerCommand : IRequest<bool>
{
	public int Id { get; set; }
	public DateTime CreateDate { get; set; }
	public int UserId { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string Email { get; set; }
	public string MobileNumber { get; set; }		
}
