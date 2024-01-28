using MediatR;
using OnlineFood.Application.Dtos.Customers;
using OnlineFood.Common;

namespace OnlineFood.Application.Features.Customers.Commands.Requests;

public class UpdateCustomerCommand : IRequest<ResultDto>
{
    public CustomerDto customer { get; set; }    
}
