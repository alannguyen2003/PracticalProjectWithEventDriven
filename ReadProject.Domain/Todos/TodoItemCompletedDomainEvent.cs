using ReadProject.SharedKernel;

namespace ReadProject.Domain.Todos;

public sealed record TodoItemCompletedDomainEvent(Guid TodoItemId) : IDomainEvent
{
    
}