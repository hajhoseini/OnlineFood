using MediatR;
using OnlineFood.Application.DTOs.Users;

namespace OnlineFood.Application.Features.Users.Queries.Requests;

public class LoginQuery:IRequest<bool>
{
    public LoginDTO login { get; set; }
}