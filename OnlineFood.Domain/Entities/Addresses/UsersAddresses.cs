using System.ComponentModel.DataAnnotations.Schema;
using OnlineFood.Domain.Entities.Base;
using OnlineFood.Domain.Entities.Customers;

namespace OnlineFood.Domain.Entities.Addresses;

public class UsersAddresses:BaseEntity
{
    public int UId { get; set; }
    public int AId { get; set; }
    [ForeignKey("AId")] public Address Address { get; set; }
    [ForeignKey("UId")] public Customer Customer { get; set; } 
}