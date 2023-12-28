using MediatR;
using OnlineFood.Application.Features.Menus.Queries.Requests;
using OnlineFood.Domain.Entities.Menus;
using OnlineFood.Domain.IReaders.Menus;

namespace OnlineFood.Application.Features.Menus.Queries.Requesthandlers
{
    public class GetListMenuQueryHandler:IRequestHandler<GetListMenuQuery,List<Menu>>
    {
        private readonly IMenuReader reader;
        public GetListMenuQueryHandler(IMenuReader reader)
        {
            this.reader = reader;
        }
        public async Task<List<Menu>> Handle(GetListMenuQuery request, CancellationToken cancellationToken)
        {
            var all = await reader.GetList(null, null);
            return all.ToList();
        }
    }
}
