using MediatR;
using MediatR.Pipeline;
using OnlineFood.Domain.Entities.Addresses;

namespace OnlineFood.Application.CRUD.AddressCRUD.Queries.ReadAddress
{
    public class ReadAddressQueryHandler : IRequestHandler<ReadAddressQuery, Address>
    {
        public async Task<Address> Handle(ReadAddressQuery request, CancellationToken cancellationToken)
        {
            Address address=new();
            return address;
        }
    }
}
