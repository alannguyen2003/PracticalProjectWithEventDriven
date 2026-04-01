using PracticalProject.SharedKernel;

namespace PracticalProject.Domain.Todos;

public sealed record TodoItemDeletedDomainEvent(Guid TodoItemId) : IDomainEvent;