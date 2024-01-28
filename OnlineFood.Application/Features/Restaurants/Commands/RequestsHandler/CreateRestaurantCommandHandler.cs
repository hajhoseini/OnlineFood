using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.Restaurants.Commands.Requests;
using OnlineFood.Application.Features.Users.Commands.Requests;
using OnlineFood.Common.Enums;
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
    public class CreateRestaurantCommandHandler : IRequestHandler<CreateRestaurantCommand, bool>
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
            //var entity = mapper.Map<Restaurant>(request);
            Restaurant entity = new()
            {
                Name = request.Name,
                password = request.password,
                MobileNumber = request.MobileNumber,
                CategoryId = request.CategoryId,
                Banner = request.Banner,
                ManagerFullName = request.ManagerFullName,
                ManagerPhoneNumber = request.ManagerPhoneNumber,
                NumberOfBranches = request.NumberOfBranches,
                IntroduceWay = request.IntroduceWay,
                CityId = request.CityId,
                ConfirmByAdmin = request.ConfirmByAdmin,
                Description = request.Description,
                IsActive = request.IsActive,
                Score = request.Score,
                DeliveryPrice = request.DeliveryPrice,
                CreditAccountNumber = request.CreditAccountNumber,
                MinimumOrderPrice = request.MinimumOrderPrice,
                AverangeDeliveryTime = request.AverangeDeliveryTime,
                Discount = request.Discount,
                SendToOutOfArea = request.SendToOutOfArea,
                PayModels = request.PayModels,
                AddressId = request.AddressId
            };
            var result = await unitOfWork.GenericReposity<Restaurant>().Create(entity);
            return result;
        }
    }
}
