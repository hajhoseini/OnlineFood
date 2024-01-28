using MediatR;
using OnlineFood.Application.DTOs.Customers;
using OnlineFood.Common;

namespace OnlineFood.Application.Features.Customers.Commands.Requests;

public class RegisterCommand : IRequest<ResultDTO>
{
    public RegisterDTO register { get; set; }
}
