using PracticalProject.SharedKernel;

namespace PracticalProject.Domain.Todos;

public sealed record TodoItemCompletedDomainEvent(Guid TodoItemId) : IDomainEvent
{
    
}