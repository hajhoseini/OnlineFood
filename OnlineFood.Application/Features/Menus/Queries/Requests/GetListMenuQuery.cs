using MediatR;
using OnlineFood.Domain.Entities.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFood.Application.Features.Menus.Queries.Requests
{
    public class GetListMenuQuery:IRequest<List<Menu>>
    {
    }
}
