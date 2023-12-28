using MediatR;
using OnlineFood.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFood.Application.Features.Restaurants.Commands.Requests
{
    public class UpdateRestaurantCommand:IRequest<bool>
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string MobileNumber { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string Banner { get; set; }
        public string ManagerFullName { get; set; }
        public string ManagerPhoneNumber { get; set; }
        public int NumberOfBranches { get; set; }
        public IntroduceWayEnum IntroduceWay { get; set; }
        public string CityId { get; set; }
        public bool ConfirmByAdmin { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int Score { get; set; }
        public decimal DeliveryPrice { get; set; }
        public string CreditAccountNumber { get; set; }
        public decimal MinimumOrderPrice { get; set; }
        public int AverangeDeliveryTime { get; set; }
        public int Discount { get; set; }
        public bool SendToOutOfArea { get; set; }
        public List<PayModelEnum> PayModels { get; set; }
        public int AddressId { get; set; }
    }
}
