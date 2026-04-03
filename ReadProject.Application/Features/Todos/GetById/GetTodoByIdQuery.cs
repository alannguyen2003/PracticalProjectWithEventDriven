using ReadProject.Application.Abstraction.Messaging;

namespace ReadProject.Application.Features.Todos.GetById;

public sealed record GetTodoByIdQuery(Guid TodoItemId) : IQuery<TodoResponse>;
