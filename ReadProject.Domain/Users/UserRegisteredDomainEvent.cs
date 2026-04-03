using ReadProject.SharedKernel;

namespace ReadProject.Domain.Users;

public sealed record UserRegisteredDomainEvent(Guid UserId) : IDomainEvent;