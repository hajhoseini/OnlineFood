using MediatR;
using OnlineFood.Application.DTOs.Customers;
using OnlineFood.Common;

namespace OnlineFood.Application.Features.Customers.Commands.Requests;

public class UpdateCustomerCommand : IRequest<ResultDTO>
{
    public CustomerDTO customer { get; set; }    
}
