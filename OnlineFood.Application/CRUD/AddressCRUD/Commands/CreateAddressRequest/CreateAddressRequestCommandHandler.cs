using MediatR;
using OnlineFood.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFood.Application.CRUD.AddressCRUD.Commands.CreateAddressRequest
{
    internal class CreateAddressRequestCommandHandler:IRequestHandler<CreateAddressRequestCommand>
    {
        IOnlineFoodDBContext _dbContext;
        public CreateAddressRequestCommandHandler(IOnlineFoodDBContext dBContext) 
        { 
            _dbContext = dBContext;
        }
        public Task Handle(CreateAddressRequestCommand request,CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
