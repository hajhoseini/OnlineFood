using MediatR;
using OnlineFood.Application.Dtos.Customers;
using OnlineFood.Common;

namespace OnlineFood.Application.Features.Customers.Commands.Requests;

public class RegisterCommand : IRequest<ResultDto>
{
    public RegisterDto register { get; set; }
}
