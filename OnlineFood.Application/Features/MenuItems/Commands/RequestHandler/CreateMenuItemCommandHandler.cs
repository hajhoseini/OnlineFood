using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.MenuItems.Commands.Request;
using OnlineFood.Application.Features.Users.Commands.Requests;
using OnlineFood.Domain.Entities.MenuItems;
using OnlineFood.Domain.Entities.Users;
using OnlineFood.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFood.Application.Features.MenuItems.Commands.RequestHandler
{
    public class CreateMenuItemCommandHandler:IRequestHandler<CreateMenuItemCommand,bool>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CreateMenuItemCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<bool> Handle(CreateMenuItemCommand request, CancellationToken cancellationToken)
        {
            var entity = mapper.Map<MenuItem>(request);
            var result = await unitOfWork.GenericReposity<MenuItem>().Create(entity);
            return result;
        }
    }
}
