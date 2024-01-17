using MediatR;
using OnlineFood.Application.Dtos.Register;
using OnlineFood.Common;

namespace OnlineFood.Application.Features.Register.Commands.Requests;

public class RegisterCommand : IRequest<ResultDto>
{
    public RegisterDto register { get; set; }
}
