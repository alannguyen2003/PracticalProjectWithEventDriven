using ReadProject.Application.Abstraction.Messaging;

namespace ReadProject.Application.Features.Users.GetById;

public sealed record GetUserByIdQuery(Guid UserId) : IQuery<UserResponse>;
