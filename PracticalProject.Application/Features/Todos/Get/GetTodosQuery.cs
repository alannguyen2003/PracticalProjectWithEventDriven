using PracticalProject.Application.Abstraction.Messaging;

namespace PracticalProject.Application.Features.Todos.Get;

public sealed record GetTodosQuery(Guid UserId) : IQuery<List<TodoResponse>>;
