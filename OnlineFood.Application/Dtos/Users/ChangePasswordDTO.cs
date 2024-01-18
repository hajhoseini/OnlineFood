using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OnlineFood.Application.Dtos.Users;

public class ChangePasswordDTO
{
    public string id;

    [DisplayName("نام کاربری")]
    [Required(ErrorMessage = "اجباری")]
    public string  UserName { get; set; }

    [DisplayName("ایمیل")]
    [Required(ErrorMessage = "اجباری")]
    [EmailAddress(ErrorMessage = "ایمیل نامعتبر")]
    public string Email { get; set; }

    [DisplayName("رمز عبور فعلی")]
    [Required(ErrorMessage = "اجباری")]
    public string CurrentPassword { get; set; }

    [DisplayName("رمز عبور جدید")]
    [Required(ErrorMessage = "اجباری")]
    [DataType(DataType.Password)]
    public string NewPassword { get; set; }

    [DisplayName("تکرار رمز عبور جدید")]
    [Required(ErrorMessage = "اجباری")]
    [DataType(DataType.Password)]
    [Compare("NewPassword", ErrorMessage = "رمز عبور و تکرار آن باید یکسان باشد")]
    public string ConfirmNewPassword { get; set; }
}