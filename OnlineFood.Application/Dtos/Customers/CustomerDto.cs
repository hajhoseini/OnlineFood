using OnlineFood.Common.Enums;

namespace OnlineFood.Application.Dtos.Customers;

public class CustomerDto
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string MobileNumber { get; set; }
    public string PhoneNumber { get; set; }
    public GenderEnum? Gender { get; set; }
    public DateTime? BirthDate { get; set; }    
}
