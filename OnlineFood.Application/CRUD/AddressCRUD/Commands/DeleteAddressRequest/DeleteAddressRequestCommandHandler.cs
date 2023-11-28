using MediatR;
using OnlineFood.Common.Interfaces;

namespace OnlineFood.Application.CRUD.AddressCRUD.Commands.DeleteAddressRequest
{
    public class DeleteAddressRequestCommandHandler : IRequestHandler<DeleteAddressRequestCommand>
    {
        private readonly IOnlineFoodDBContext _dbContext;
        public DeleteAddressRequestCommandHandler(IOnlineFoodDBContext dBContext)
        {
            _dbContext = dBContext;
        }

        public Task Handle(DeleteAddressRequestCommand request, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
