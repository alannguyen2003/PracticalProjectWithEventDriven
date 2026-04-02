using PracticalProject.Application.Abstraction.Messaging;

namespace PracticalProject.Application.Features.Todos.Update;

public sealed record UpdateTodoCommand(
    Guid TodoItemId,
    string Description) : ICommand;