using ReadProject.Application.Abstraction.Messaging;

namespace ReadProject.Application.Features.Users.GetByEmail;

public sealed record GetUserByEmailQuery(string Email) : IQuery<UserResponse>;
