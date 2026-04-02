using PracticalProject.Application.Abstraction.Messaging;

namespace PracticalProject.Application.Features.Users.Login;

public sealed record LoginUserCommand(string Email, string Password) : ICommand<string>;
