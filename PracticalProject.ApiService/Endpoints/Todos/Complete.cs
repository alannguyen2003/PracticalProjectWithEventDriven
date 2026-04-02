using PracticalProject.ApiService.Extensions;
using PracticalProject.ApiService.Infrastructure;
using PracticalProject.Application.Abstraction.Messaging;
using PracticalProject.Application.Features.Todos.Complete;
using PracticalProject.SharedKernel;

namespace PracticalProject.ApiService.Endpoints.Todos;

public sealed class Complete : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapPut("todos/{id:guid}/complete", async (
                Guid id,
                ICommandHandler<CompleteTodoCommand> handler,
                CancellationToken cancellationToken) =>
            {
                var command = new CompleteTodoCommand(id);

                Result result = await handler.Handle(command, cancellationToken);

                return result.Match(Results.NoContent, CustomResult.Problem);
            })
            .WithTags(Tags.Todos)
            .RequireAuthorization();
    }
}