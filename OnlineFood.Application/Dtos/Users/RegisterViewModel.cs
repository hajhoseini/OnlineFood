using System.ComponentModel.DataAnnotations;

namespace OnlineFood.Application.Dtos.Users;

public class RegisterViewModel
{
    [Required(ErrorMessage = "باید پرده")]
    public string UserName { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    public string ConfirmPassword { get; set; }
}