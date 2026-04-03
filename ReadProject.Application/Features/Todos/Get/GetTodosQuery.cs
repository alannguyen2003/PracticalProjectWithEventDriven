using ReadProject.Application.Abstraction.Messaging;

namespace ReadProject.Application.Features.Todos.Get;

public sealed record GetTodosQuery(Guid UserId) : IQuery<List<TodoResponse>>;
