using MediatR;
using OnlineFood.Domain.Entities.Addresses;

namespace OnlineFood.Application.CRUD.AddressCRUD.Commands.DeleteAddressRequest
{
    public class DeleteAddressRequestCommand:IRequest
    {
        public Address address {  get; set; }
    }
}