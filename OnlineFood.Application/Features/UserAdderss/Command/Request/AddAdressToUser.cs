using MediatR;

namespace OnlineFood.Application.Features.UserAdderss.Command.Request;

public class AddAdressToUser:IRequest<bool>
{
    public int addressid { get; set; }
    public int userid { get; set; }
}