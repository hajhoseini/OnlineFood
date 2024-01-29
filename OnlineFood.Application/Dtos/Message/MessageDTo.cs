using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace OnlineFood.Application.DTOs.Message;

public class MessageDTO
{
    [Required]
    [DisplayName("عنوان پیام")]
    public string Title { get; set; }

    [Required]
    [DisplayName("متن پیام")]
    public string Text { get; set; }

    [Required]
    [DisplayName("نوع ارسال")]
    public int  SendTypeEnum  { get; set; }// if it was sms we save 1 and it was Email we save 2
}