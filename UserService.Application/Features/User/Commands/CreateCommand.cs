using MediatR;
using UserService.Application.Common.Messages;
using UserService.Application.DTOs;

namespace UserService.Application.Features.User.Commands;

public class CreateCommand(string name, string userName, string password) : IRequest<Messages>
{
    public string Name { get; set; } = name;
    public string UserName { get; set; } = userName;
    public string Password { get; set; } = password;
}
