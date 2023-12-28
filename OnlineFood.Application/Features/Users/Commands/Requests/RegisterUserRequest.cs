using MediatR;
using OnlineFood.Application.Dtos.Users;

namespace OnlineFood.Application.Features.Users.Commands.Requests;

public class RegisterUserRequest:IRequest<bool>
{
    public RegisterViewModel  Register { get; set; }
}