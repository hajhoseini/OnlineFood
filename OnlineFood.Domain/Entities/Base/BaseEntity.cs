using System.ComponentModel.DataAnnotations;

namespace OnlineFood.Domain.Entities.Base;

public class BaseEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    public DateTime CreateDate { get; set; }
}