using PracticalProject.Application.Abstraction.Messaging;

namespace PracticalProject.Application.Features.Todos.Delete;

public sealed record DeleteTodoCommand(Guid TodoItemId) : ICommand;
