using PracticalProject.ApiService.Extensions;
using PracticalProject.ApiService.Infrastructure;
using PracticalProject.Application.Abstraction.Messaging;
using PracticalProject.Application.Features.Todos.Copy;
using PracticalProject.SharedKernel;

namespace PracticalProject.ApiService.Endpoints.Todos;

public sealed class Copy : IEndpoint
{
    public sealed class Request
    {
        public Guid UserId { get; set; }
        public Guid TodoId { get; set; }
    }

    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapPost("todos/{todoId}/copy", async (
                Guid todoId,
                Request request,
                ICommandHandler<CopyTodoCommand, Guid> handler,
                CancellationToken cancellationToken) =>
            {
                var command = new CopyTodoCommand
                {
                    UserId = request.UserId,
                    TodoId = todoId
                };

                Result<Guid> result = await handler.Handle(command, cancellationToken);

                return result.Match(Results.Ok, CustomResult.Problem);
            })
            .WithTags(Tags.Todos)
            .RequireAuthorization();
    }
}