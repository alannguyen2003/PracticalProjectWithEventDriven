using ReadProject.SharedKernel;

namespace ReadProject.Domain.Todos;

public sealed record TodoItemDeletedDomainEvent(Guid TodoItemId) : IDomainEvent;