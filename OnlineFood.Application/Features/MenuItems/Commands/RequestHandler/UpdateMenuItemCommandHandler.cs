using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.MenuItems.Commands.Request;
using OnlineFood.Domain.Entities.MenuItems;
using OnlineFood.Domain.IRepositories.MenuItems;

namespace OnlineFood.Application.Features.MenuItems.Commands.RequestHandler
{
    public class UpdateMenuItemCommandHandler:IRequestHandler<UpdateMenuItemCommand,bool>
    {
        private readonly IMenuItemRepository repository;
        private readonly IMapper mapper;

        public UpdateMenuItemCommandHandler(IMenuItemRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public Task<bool> Handle(UpdateMenuItemCommand request, CancellationToken cancellationToken)
        {
            var entity = mapper.Map<MenuItem>(request);
            return repository.Update(entity);
        }
    }
}
