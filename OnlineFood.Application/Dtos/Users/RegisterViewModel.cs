using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OnlineFood.Application.DTOs.Users;

public class RegisterViewModel
{
    [DisplayName("نام کاربری")]
    [Required(ErrorMessage = "اجباری")]
    public string UserName { get; set; }


    [DisplayName("ایمیل")]
    [Required(ErrorMessage = "اجباری")]
    [EmailAddress(ErrorMessage = "ایمیل نامعتبر")]
    public string Email { get; set; }

    [DisplayName("رمز عبور")]
    [Required(ErrorMessage = "اجباری")]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [DisplayName("تکرار رمز عبور")]
    [Required(ErrorMessage = "اجباری")]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "رمز عبور و تکرار آن باید یکسان باشد")]
    public string ConfirmPassword { get; set; }
}