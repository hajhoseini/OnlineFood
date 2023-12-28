using MediatR;
using OnlineFood.Application.Features.Customers.Queries.Requests;
using OnlineFood.Application.Features.MenuItems.Queries.Requests;
using OnlineFood.Domain.Entities.Customers;
using OnlineFood.Domain.Entities.MenuItems;
using OnlineFood.Domain.IReaders.Customers;
using OnlineFood.Domain.IReaders.MenuItems;

namespace OnlineFood.Application.Features.MenuItems.Queries.RequestHandlers
{
    public class GetMenuItemQueryHandler:IRequestHandler<GetMenuItemQuery,MenuItem>
    {
        private readonly IMenuItemReader reader;

        public GetMenuItemQueryHandler(IMenuItemReader reader)
        {
            this.reader = reader;
        }

        public async Task<MenuItem> Handle(GetMenuItemQuery request, CancellationToken cancellationToken)
        {
            return await reader.GetById(request.Id);
        }
    }
}
