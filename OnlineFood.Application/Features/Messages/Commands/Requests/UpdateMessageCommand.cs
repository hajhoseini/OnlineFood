using MediatR;
using OnlineFood.Common.Enums;

namespace OnlineFood.Application.Features.Messages.Commands.Requests;

public class UpdateMessageCommand : IRequest<bool>
{
	public int Id { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }
    public SendTypeEnum SendType { get; set; }
}