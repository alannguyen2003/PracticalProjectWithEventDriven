using PracticalProject.ApiService.Extensions;
using PracticalProject.ApiService.Infrastructure;
using PracticalProject.Application.Abstraction.Messaging;
using PracticalProject.Application.Features.Todos.Delete;
using PracticalProject.SharedKernel;

namespace PracticalProject.ApiService.Endpoints.Todos;

public sealed class Delete : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapDelete("todos/{id:guid}", async (
                Guid id,
                ICommandHandler<DeleteTodoCommand> handler,
                CancellationToken cancellationToken) =>
            {
                var command = new DeleteTodoCommand(id);

                Result result = await handler.Handle(command, cancellationToken);

                return result.Match(Results.NoContent, CustomResult.Problem);
            })
            .WithTags(Tags.Todos)
            .RequireAuthorization();
    }
}