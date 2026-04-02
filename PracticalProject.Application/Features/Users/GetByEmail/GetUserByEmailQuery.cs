using PracticalProject.Application.Abstraction.Messaging;

namespace PracticalProject.Application.Features.Users.GetByEmail;

public sealed record GetUserByEmailQuery(string Email) : IQuery<UserResponse>;
