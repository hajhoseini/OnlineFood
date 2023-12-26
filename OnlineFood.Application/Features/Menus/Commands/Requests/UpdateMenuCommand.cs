using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFood.Application.Features.Menus.Commands.Requests
{
    public class UpdateMenuCommand:IRequest<bool>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int MenuCategoryId { get; set; }
    }
}
