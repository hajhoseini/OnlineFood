using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.Restaurants.Commands.Requests;
using OnlineFood.Application.Features.Users.Commands.Requests;
using OnlineFood.Domain.Entities.Resturants;
using OnlineFood.Domain.Entities.Users;
using OnlineFood.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFood.Application.Features.Restaurants.Commands.RequestsHandler
{
    public class CreateRestaurantCommandHandler:IRequestHandler<CreateRestaurantCommand,bool>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CreateRestaurantCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<bool> Handle(CreateRestaurantCommand request, CancellationToken cancellationToken)
        {
            var entity = mapper.Map<Restaurant>(request);
            var result = await unitOfWork.GenericReposity<Restaurant>().Create(entity);
            return result;
        }
    }
}
