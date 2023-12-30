using OnlineFood.Common.Enums;

namespace OnlineFood.Application.Dtos.Message;

public class MessageDTo
{
    public string Title { get; set; }
    public string Text { get; set; }
    public int  SendTypeEnum  { get; set; }// if it was sms we save 1 and it was Email we save 2
}