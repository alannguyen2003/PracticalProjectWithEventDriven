using PracticalProject.Application.Abstraction.Messaging;

namespace PracticalProject.Application.Features.Users.GetById;

public sealed record GetUserByIdQuery(Guid UserId) : IQuery<UserResponse>;
