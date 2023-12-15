using MediatR;

namespace OnlineFood.Application.Features.Customers.Commands.Requests;

public class DeleteCustomerCommand : IRequest<bool>
{
	public int Id { get; set; }
}
