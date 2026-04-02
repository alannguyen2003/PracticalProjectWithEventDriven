using PracticalProject.Application.Abstraction.Messaging;

namespace PracticalProject.Application.Features.Todos.GetById;

public sealed record GetTodoByIdQuery(Guid TodoItemId) : IQuery<TodoResponse>;
