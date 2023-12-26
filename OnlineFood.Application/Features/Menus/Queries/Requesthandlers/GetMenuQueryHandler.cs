using MediatR;
using OnlineFood.Application.Features.Menus.Queries.Requests;
using OnlineFood.Domain.Entities.Menus;
using OnlineFood.Domain.IReaders.Menus;

namespace OnlineFood.Application.Features.Menus.Queries.Requesthandlers
{
    public class GetMenuQueryHandler:IRequestHandler<GetMenuQuery,Menu>
    {
        private readonly IMenuReader reader;
        public GetMenuQueryHandler(IMenuReader reader)
        {
            this.reader = reader;
        }

        public async Task<Menu> Handle(GetMenuQuery request, CancellationToken cancellationToken)
        {
            return await reader.GetById(request.Id);
        }
    }
}
