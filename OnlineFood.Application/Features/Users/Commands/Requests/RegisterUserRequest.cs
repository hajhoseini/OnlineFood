using MediatR;
using OnlineFood.Application.DTOs.Users;

namespace OnlineFood.Application.Features.Users.Commands.Requests;

public class RegisterUserRequest:IRequest<bool>
{
    public RegisterViewModel  Register { get; set; }
}