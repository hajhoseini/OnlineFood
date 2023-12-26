using MediatR;
using OnlineFood.Application.Features.Menus.Commands.Requests;
using OnlineFood.Application.Features.Users.Commands.Requests;
using OnlineFood.Domain.Entities.Menus;
using OnlineFood.Domain.Entities.Users;
using OnlineFood.Domain.InterfaceRepositories.Users;
using OnlineFood.Domain.IRepositories.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFood.Application.Features.Menus.Commands.RequestHandler
{
    public class DeleteMenuCommandHandler:IRequestHandler<DeleteMenuCommand,bool>
    {
        private readonly IMenuRepository repository;

        public DeleteMenuCommandHandler(IMenuRepository repository)
        {
            this.repository = repository;
        }

        public Task<bool> Handle(DeleteMenuCommand request, CancellationToken cancellationToken)
        {
            Menu entity = new Menu { Id = request.Id };
            return repository.Delete(entity);
        }
    }
}
