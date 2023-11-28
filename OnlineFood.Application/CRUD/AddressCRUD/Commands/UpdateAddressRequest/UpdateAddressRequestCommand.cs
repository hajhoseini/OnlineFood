using MediatR;
using OnlineFood.Domain.Entities.Addresses;

namespace OnlineFood.Application.CRUD.AddressCRUD.Commands.UpdateAddressRequest
{
    public class UpdateAddressRequestCommand:IRequest
    {
        public Address address {  get; set; }
    }
}
