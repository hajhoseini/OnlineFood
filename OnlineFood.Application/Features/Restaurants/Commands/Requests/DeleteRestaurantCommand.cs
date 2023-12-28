using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFood.Application.Features.Restaurants.Commands.Requests
{
    public class DeleteRestaurantCommand:IRequest<bool>
    {
        public int Id { get; set; }
    }
}
