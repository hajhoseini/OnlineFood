using System.ComponentModel.DataAnnotations;

namespace OnlineFood.Common.Enums;

public enum PayModelEnum
{
    [Display(Name ="کارت اعتباری")]
    CreditCard,
    [Display(Name ="حضوری")]
    InPerson,
    [Display(Name ="هردو")]
    Both
}
