using MediatR;
using OnlineFood.Application.Features.Customers.Queries.Requests;
using OnlineFood.Application.Features.MenuItems.Queries.Requests;
using OnlineFood.Domain.Entities.Customers;
using OnlineFood.Domain.Entities.MenuItems;
using OnlineFood.Domain.IReaders.Customers;
using OnlineFood.Domain.IReaders.MenuItems;

namespace OnlineFood.Application.Features.MenuItems.Queries.RequestHandlers
{
    public class GetListMenuItemQueryHandler:IRequestHandler<GetListMenuItemQuery,List<MenuItem>>
    {
        private readonly IMenuItemReader reader;

        public GetListMenuItemQueryHandler(IMenuItemReader reader)
        {
            this.reader = reader;
        }

        public async Task<List<MenuItem>> Handle(GetListMenuItemQuery request, CancellationToken cancellationToken)
        {
            var all = await reader.GetList(null, null);
            return all.ToList();
        }
    }
}
