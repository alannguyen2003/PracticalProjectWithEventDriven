using PracticalProject.SharedKernel;

namespace PracticalProject.Domain.Todos;

public class TodoItemCreatedDomainEvent(Guid TodoItemId) : IDomainEvent;