using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.Menus.Commands.Requests;
using OnlineFood.Domain.Entities.Menus;
using OnlineFood.Domain.InterfaceRepositories.Users;
using OnlineFood.Domain.IRepositories.Menus;

namespace OnlineFood.Application.Features.Menus.Commands.RequestHandler
{
    public class UpdateMenuCommandHandler:IRequestHandler<UpdateMenuCommand,bool>
    {
        private readonly IMenuRepository repository;
        private readonly IMapper _mapper;

        public UpdateMenuCommandHandler(IMenuRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this._mapper = mapper;
        }

        public Task<bool> Handle(UpdateMenuCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Menu>(request);
            return repository.Update(entity);
        }
    }
}
