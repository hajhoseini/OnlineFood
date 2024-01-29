using OnlineFood.Application.DTOs.RestaurantCategory;

namespace OnlineFood.Application.DTOs.Customers;

public class CustomerProfileDTO
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public List<RestaurantCategoryDTO> ss { get; set; }
}
