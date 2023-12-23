using MediatR;
using OnlineFood.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFood.Application.Features.Messages.Commands.Requests
{
    public class CreateMessageCommand : IRequest<bool>
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public SendTypeEnum SendType { get; set; }
    }
}
