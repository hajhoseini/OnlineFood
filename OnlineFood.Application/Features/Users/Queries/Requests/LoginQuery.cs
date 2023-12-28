using MediatR;
using OnlineFood.Application.Dtos.Users;

namespace OnlineFood.Application.Features.Users.Queries.Requests;

public class LoginQuery:IRequest<bool>
{
    public LoginDto login { get; set; }
}