using OnlineFood.Common.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OnlineFood.Application.Dtos.Restaurant
{
    public class RegisterRestaurantDTO
    {
        public int UserId { get; set; }
        [Required]
        [DisplayName("شماره موبایل")]
        public string MobileNumber { get; set; }
        [Required]
        [DisplayName("نام رستوران")]
        public string Name { get; set; }
        [Required]
        [DisplayName("دسته ی رستوران")]
        public int CategoryId { get; set; }
        [DisplayName("نماد")]
        public string Banner { get; set; }
        [Required]
        [DisplayName("نام مدیر")]
        public string ManagerFullName { get; set; }
        [Required]
        [DisplayName("تلفن مدیر")]
        public string ManagerPhoneNumber { get; set; }
        [Required]
        [DisplayName("روش آشنایی با سایت")]
        public IntroduceWayEnum IntroduceWay { get; set; }
        [Required]
        [DisplayName("نام استان")]
        public string ProvinceId { get; set; }
        [Required]
        [DisplayName("نام شهر")]
        public string CityId { get; set; }
        [DisplayName("توضیحات")]
        public string Description { get; set; }
        [Required]
        [DisplayName("شماره حساب")]
        public string CreditAccountNumber { get; set; }
        [DisplayName("حداقل میزان سفارش")]
        public decimal MinimumOrderPrice { get; set; }
        [DisplayName("قابلیت ارسال به خارج از محدوده")]
        public bool SendToOutOfArea { get; set; }
        [Required]
        [DisplayName("روش پرداخت")]
        public List<PayModelEnum> PayModels { get; set; }
        public int AddressId { get; set; }
    }
}
