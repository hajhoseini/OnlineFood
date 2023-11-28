using MediatR;
using OnlineFood.Common.Interfaces;

namespace OnlineFood.Application.CRUD.AddressCRUD.Commands.UpdateAddressRequest
{
    public class UpdateAddressRequestCommandHandler : IRequestHandler<UpdateAddressRequestCommand>
    {
        IOnlineFoodDBContext _dBContext;
        public UpdateAddressRequestCommandHandler(IOnlineFoodDBContext dBContext)
        {
            _dBContext = dBContext;
        }
        public Task Handle(UpdateAddressRequestCommand request, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
