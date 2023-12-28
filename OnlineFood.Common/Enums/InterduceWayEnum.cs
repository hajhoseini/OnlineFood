using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OnlineFood.Common.Enums;

public enum IntroduceWayEnum
{
    [Display(Name ="جست و جو در اینترنت")]
    SearchViaInternet,
    [Display(Name = "معرفی توسط دوستان")]
    ByFriend,
    [Display(Name ="تیلیغات")]
    Advertisement,
    [Display(Name ="سایر...")]
    Others
}