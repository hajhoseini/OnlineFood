using OnlineFood.Common.Enums;
using OnlineFood.Domain.Entities.Base;

namespace OnlineFood.Domain.Entities.Resturant
{
    public class Resturant : BaseEntity
    {
        public string Name { get; set; }
        public string Banner { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public string ManagerFullName { get; set; }
        public string ManagerPhoneNumber { get; set; }
        public int NumberOfBranches { get; set; }
        public InterduceWayEnum InterducedWay { get; set; }
        public string Provice {  get; set; }
        public string City {  get; set; }
        public string SignUpDate {  get; set; }
        public bool DoesAcceptedByAdmin {  get; set; }
        public int WorkTimeId { get; set; }
        public int SocialMediaId { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public float Score { get; set; }
        public string DeliveryPrice { get; set; }
        public string CreditAccountNumber { get; set; }
        public string MinimumOrderPrice { get; set; }
        public string AverangeDeliveryTime { get; set; }
        public int Discount { get; set; }
        public bool DoesHaveOutOfAreaSend { get; set; }
        public PayModelEnum PayModels { get; set; }
        public int AddressId { get; set; }
    }
}
