using MediatR;
using OnlineFood.Domain.Entities.Addresses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OnlineFood.Application.CRUD.AddressCRUD.Commands.CreateAddressRequest
{
    public class CreateAddressRequestCommand : IRequest
    {
        public Address address {  get; set; }
    }
}
