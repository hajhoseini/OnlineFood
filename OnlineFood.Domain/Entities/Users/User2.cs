using OnlineFood.Domain.Entities.Base;

namespace OnlineFood.Domain.Entities.Users;

public class User2 : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
}