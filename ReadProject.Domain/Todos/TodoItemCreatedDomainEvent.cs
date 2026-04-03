using ReadProject.SharedKernel;

namespace ReadProject.Domain.Todos;

public class TodoItemCreatedDomainEvent(Guid TodoItemId) : IDomainEvent;