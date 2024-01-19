using MediatR;
using OnlineFood.Application.Features.UserAdderss.Command.Request;
using OnlineFood.Domain.Entities.Addresses;
using OnlineFood.Domain.IRepositories.UserAdderss;

namespace OnlineFood.Application.Features.UserAdderss.Command.RequestHandler;

public class AddAdressToUserHandler:IRequestHandler<AddAdressToUser,bool>
{
    private readonly IUserAdderssRepository _adderssRepository;

    public AddAdressToUserHandler(IUserAdderssRepository adderssRepository)
    {
        _adderssRepository = adderssRepository;
    }

    public async Task<bool> Handle(AddAdressToUser request, CancellationToken cancellationToken)
    {
        var Useradderss = new UsersAddresses()
        {
            UId = request.userid,
            AId = request.addressid
        };
        var test=await _adderssRepository.Create(Useradderss);
        return test;
    }
}