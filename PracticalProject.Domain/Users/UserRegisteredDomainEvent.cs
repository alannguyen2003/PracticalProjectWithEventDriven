using PracticalProject.SharedKernel;

namespace PracticalProject.Domain.Users;

public sealed record UserRegisteredDomainEvent(Guid UserId) : IDomainEvent;