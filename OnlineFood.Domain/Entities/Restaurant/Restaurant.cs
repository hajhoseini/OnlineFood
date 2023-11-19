using OnlineFood.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFood.Domain.Entities.Restaurant
{
    public class Restaurant
    {
        public int WorkTimeId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Banner { get; set; }
        public int CategoryId {  get; set; }
        public string Description {  get; set; }
        public bool IsActive {  get; set; }
        public string PhoneNumber {  get; set; }
        public string ManagerFullName {  get; set; }
        public string ManagerPhone { get; set; }
        public int NumberOfBranches {  get; set; }
        public InterducedWayEnum InterduceWay { get; set; }
        public ProvinceEnum Province { get; set; }
        public int CityId { get; set; }
        public string JoinDate {  get; set; }
        public bool DoesAcceptedByAdmin {  get; set; }
        public float Score {  get; set; }
        public string CreditAccountNum {  get; set; }
        public string DeliveryPrice {  get; set; }
        public string MinimumOrderPrice {  get; set; }
        public string AverangeDeliveryTime { get; set; }
        public int Discount { get; set; }
        public bool DoesSendOutOfArea {  get; set; }
        public PaymentWayEnum PaymentWay { get; set; }
        public int AddressId {  get; set; }
    }
}
