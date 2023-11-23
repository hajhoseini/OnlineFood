using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using OnlineFood.Domain.Entities.Base;

namespace OnlineFood.Domain.Entities.Users;

public class User :IdentityUser<string>
{
    [Required]
    [DefaultValue(2)]
    public int RoleId { get; set; }
    [Required] 
    [DefaultValue(false)]
    public bool AdminApp { get; set; }
    [Required] 
    [DefaultValue(true)]
    public bool Status { get; set; }
}