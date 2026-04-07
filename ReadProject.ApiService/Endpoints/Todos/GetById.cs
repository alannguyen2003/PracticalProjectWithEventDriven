using ReadProject.ApiService.Extensions;
using ReadProject.ApiService.Infrastructure;
using ReadProject.Application.Abstraction.Messaging;
using ReadProject.Application.Features.Todos.GetById;
using ReadProject.SharedKernel;

namespace ReadProject.ApiService.Endpoints.Todos;

public sealed class GetById : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("todos/{id:guid}", async (
                Guid id,
                IQueryHandler<GetTodoByIdQuery, TodoResponse> handler,
                CancellationToken cancellationToken) =>
            {
                var command = new GetTodoByIdQuery(id);

                Result<TodoResponse> result = await handler.Handle(command, cancellationToken);

                return result.Match(Results.Ok, CustomResult.Problem);
            })
            .WithTags(Tags.Todos)
            .RequireAuthorization();
    }
}