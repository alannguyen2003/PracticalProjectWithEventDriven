using PracticalProject.Application.Abstraction.Messaging;

namespace PracticalProject.Application.Features.Todos.Copy;

public sealed class CopyTodoCommand : ICommand<Guid>
{
    public Guid UserId { get; set; }
    public Guid TodoId { get; set; }
}