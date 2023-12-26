using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFood.Application.Features.WorkTimes.Commands.Request
{
    public class DeleteWorkTimeCommand:IRequest<bool>
    {
        public int Id { get; set; }
    }
}
