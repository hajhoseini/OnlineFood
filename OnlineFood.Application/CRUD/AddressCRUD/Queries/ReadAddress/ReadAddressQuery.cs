using MediatR;
using OnlineFood.Domain.Entities.Addresses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFood.Application.CRUD.AddressCRUD.Queries.ReadAddress
{
    public class ReadAddressQuery:IRequest<Address>
    {
        public Address address {  get; set; }
    }
}
