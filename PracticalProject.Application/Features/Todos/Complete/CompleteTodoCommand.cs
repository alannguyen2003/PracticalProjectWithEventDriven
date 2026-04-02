using PracticalProject.Application.Abstraction.Messaging;

namespace PracticalProject.Application.Features.Todos.Complete;

public sealed record CompleteTodoCommand(Guid TodoItemId) : ICommand;
