using PracticalProject.Application.Abstraction.Messaging;

namespace PracticalProject.Application.Features.Users.Register;

public sealed record RegisterUserCommand(string Email, string FirstName, string LastName, string Password)
    : ICommand<Guid>;