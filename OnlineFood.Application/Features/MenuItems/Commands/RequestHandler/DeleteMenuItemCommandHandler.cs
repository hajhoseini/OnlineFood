using MediatR;
using OnlineFood.Application.Features.MenuItems.Commands.Request;
using OnlineFood.Application.Features.Users.Commands.Requests;
using OnlineFood.Domain.Entities.MenuItems;
using OnlineFood.Domain.Entities.Users;
using OnlineFood.Domain.InterfaceRepositories.Users;
using OnlineFood.Domain.IRepositories.MenuItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFood.Application.Features.MenuItems.Commands.RequestHandler
{
    public class DeleteMenuItemCommandHandler:IRequestHandler<DeleteMenuItemCommand,bool>
    {
        private readonly IMenuItemRepository repository;

        public DeleteMenuItemCommandHandler(IMenuItemRepository repository)
        {
            this.repository = repository;
        }

        public Task<bool> Handle(DeleteMenuItemCommand request, CancellationToken cancellationToken)
        {
            MenuItem entity = new MenuItem { Id = request.Id };
            return repository.Delete(entity);
        }
    }
}
